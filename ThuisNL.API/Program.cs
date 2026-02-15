using ThuisNL.Infrastructure.Extensions;  // <-- solo este using nuevPo


var builder = WebApplication.CreateBuilder(args);
// Tus services aquí (DbContext, controllers, etc.)

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// ... otros AddSwagger, AddAuthentication, etc.

builder.Services.AddControllers();

// Registro DB limpio 🔥 (todo el EF escondido en Infrastructure)
builder.Services.AddDatabase(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Endpoint básico para ver que API vive
app.MapGet("/", () => "¡ThuisNL API viva y clean! 🔥🏡 Conectando refugiados y locales en NL");

app.Run();