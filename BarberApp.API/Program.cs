using BarberApp.API.Extensions;
using Microsoft.OpenApi;


var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddProjectServices(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "BarberApp API",
        Version = "v1"
    });

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter: Bearer {token}"
    };

    options.AddSecurityDefinition("Bearer", securityScheme);

    options.AddSecurityRequirement(document =>
    {

        var schemeRef = new OpenApiSecuritySchemeReference("Bearer", document);

        return new OpenApiSecurityRequirement
        {
            [schemeRef] = new List<string>()
        };
    });
});
#endregion

var app = builder.Build();

#region Middleware Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        // This ensures the page finds the correct Swashbuckle generation endpoint
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "BarberApp API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
#endregion

app.Run();