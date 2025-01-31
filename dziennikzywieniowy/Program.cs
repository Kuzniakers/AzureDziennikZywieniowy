using dziennikzywieniowy.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja us³ug
builder.Services.AddControllersWithViews(); // Dodaj MVC
builder.Services.AddRazorPages(); // Razor Pages (jeœli potrzebne)

// Konfiguracja Entity Framework Core z SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dodanie CORS (jeœli potrzebne do obs³ugi API)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Budowanie aplikacji
var app = builder.Build();

// Konfiguracja middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Obs³uga b³êdów
    app.UseHsts(); // Bezpieczeñstwo HTTPS
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Obs³uga plików statycznych

app.UseRouting();

// Middleware autoryzacji (jeœli u¿ywane)
app.UseAuthentication();
app.UseAuthorization();

// Middleware CORS (jeœli u¿ywane)
app.UseCors("AllowAll");

// Mapowanie tras
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllers(); // Obs³uga Web API
app.MapRazorPages(); // Obs³uga Razor Pages (opcjonalne)

// Uruchomienie aplikacji
app.Run();
