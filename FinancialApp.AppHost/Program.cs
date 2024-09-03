using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configurar servi�os e middlewares aqui, por exemplo:
// Adicionar e configurar cache localmente se necess�rio
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Configurar as APIs e o frontend
var apiService = builder.Services.AddControllersWithViews(); // Assumindo que isso configura seu ApiService

var app = builder.Build();

// Configurar middlewares, como rotas, autentica��o, etc.
app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Para a API
    endpoints.MapRazorPages(); // Para o frontend, se aplic�vel
});

app.Run();
