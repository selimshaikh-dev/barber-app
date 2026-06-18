using BarberApp.Application.DTOs.AuthDtos;
using BarberApp.Application.Interfaces.Services;
using BarberApp.Application.Interfaces.UnitOfWork;
using BarberApp.Domain.Entities;
using BarberApp.Domain.Enums;

namespace BarberApp.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasherService _passwordHasher;
        private readonly IJwtService _jwtService;

        public AuthService(
            IUnitOfWork unitOfWork,
            IPasswordHasherService passwordHasher,
            IJwtService jwtService)
        {
            _unitOfWork = unitOfWork;
            _passwordHasher = passwordHasher;
            _jwtService = jwtService;
        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterRequestDto dto)
        {
            if (dto.Password != dto.ConfirmPassword)
                throw new Exception("Passwords do not match");

            var exists = await _unitOfWork.Users.GetByMobileAsync(dto.MobileNumber);

            if (exists != null)
                throw new Exception("Mobile number already exists");

            var user = new User
            {
                FullName = dto.FullName,
                MobileNumber = dto.MobileNumber,
                PasswordHash = _passwordHasher.Hash(dto.Password),
                Role = UserRole.Client,
                CreatedAt = DateTime.UtcNow,
                IsActive = true
            };

            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.SaveChangesAsync();

            var token = _jwtService.GenerateToken(user);

            return new AuthResponseDto
            {
                UserId = user.Id,
                FullName = user.FullName,
                MobileNumber = user.MobileNumber,
                Role = user.Role,
                Token = token,
                ExpiresAt = DateTime.UtcNow.AddDays(7)
            };
        }

        public async Task<AuthResponseDto> LoginAsync(LoginRequestDto dto)
        {
            var user = await _unitOfWork.Users.GetByMobileAsync(dto.MobileNumber);

            if (user == null)
                throw new Exception("User not found");

            var isValid = _passwordHasher.Verify(dto.Password, user.PasswordHash);

            if (!isValid)
                throw new Exception("Invalid credentials");

            var token = _jwtService.GenerateToken(user);

            return new AuthResponseDto
            {
                UserId = user.Id,
                FullName = user.FullName,
                MobileNumber = user.MobileNumber,
                Role = user.Role,
                Token = token,
                ExpiresAt = DateTime.UtcNow.AddDays(7)
            };
        }
    }
}