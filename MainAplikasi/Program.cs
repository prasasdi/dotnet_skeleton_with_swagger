using MainAplikasi.Extensions;
using Microsoft.AspNetCore.HttpOverrides;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(),
"/nlog.config"));
// Add services to the container.

builder.Services.AddControllers()
.AddApplicationPart(typeof(MainAplikasi.Presentation.AssemblyReference).Assembly);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();
builder.Services.ConfigureSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Ad1ee Skeleton v1");
    s.SwaggerEndpoint("/swagger/v2/swagger.json", "Ad1ee Skeleton v2");
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();
app.Run();