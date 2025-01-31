using dziennikzywieniowy.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracja us�ug
builder.Services.AddControllersWithViews(); // Dodaj MVC
builder.Services.AddRazorPages(); // Razor Pages (je�li potrzebne)

// Konfiguracja Entity Framework Core z SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Dodanie CORS (je�li potrzebne do obs�ugi API)
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
    app.UseExceptionHandler("/Home/Error"); // Obs�uga b��d�w
    app.UseHsts(); // Bezpiecze�stwo HTTPS
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Obs�uga plik�w statycznych

app.UseRouting();

// Middleware autoryzacji (je�li u�ywane)
app.UseAuthentication();
app.UseAuthorization();

// Middleware CORS (je�li u�ywane)
app.UseCors("AllowAll");

// Mapowanie tras
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllers(); // Obs�uga Web API
app.MapRazorPages(); // Obs�uga Razor Pages (opcjonalne)

// Uruchomienie aplikacji
app.Run();
