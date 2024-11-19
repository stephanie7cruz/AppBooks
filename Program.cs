using AppBooks.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Agregar servicios para la autenticación e identidad
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
    options.SignIn.RequireConfirmedAccount = false) // Configura las opciones de la identidad, si es necesario.
    .AddEntityFrameworkStores<ApplicationDbContext>()  // Usa Entity Framework para almacenar la identidad en la base de datos.
    .AddDefaultTokenProviders();  // Agrega los proveedores de tokens por defecto (como los tokens de confirmación de cuenta).

// 3. Agregar Razor Pages (si estás utilizando Identity para páginas Razor)
builder.Services.AddRazorPages();

// 4. Agregar servicios para controladores con vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 5. Configurar el pipeline de la aplicación
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 6. Habilitar autenticación y autorización
app.UseAuthentication();
app.UseAuthorization();

// 7. Configurar las rutas de los controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Asegúrate de que el controlador Books sea el predeterminado


// 8. Configurar endpoints para Razor Pages (si utilizas Identity)
app.MapRazorPages();

app.Run();
