var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvcCore();
builder.Services.AddRouting();
builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();
app.UseEndpoints(endpoints => endpoints.MapControllers());

var a = () => Console.WriteLine("kek");
a.Invoke();

app.Run();
