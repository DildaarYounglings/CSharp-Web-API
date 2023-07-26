var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// code creates a CORS policy for the app //
builder.Services.AddCors(policy => policy.AddPolicy("policy1", build =>
{
    // .WithOrigins(takes a string that specifies the site url that is interacting with the api) //
    // .AllowAnyOrigin() exist is convinient but definitely not good practice if this is going to be used for monetary means//
    build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}
));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// UseCors(takes a string that represents the the name set above) //
app.UseCors("policy1");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
