using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Configurar serviços e middlewares aqui, por exemplo:
// Adicionar e configurar cache localmente se necessário
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Configurar as APIs e o frontend
var apiService = builder.Services.AddControllersWithViews(); // Assumindo que isso configura seu ApiService

var app = builder.Build();

// Configurar middlewares, como rotas, autenticação, etc.
app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Para a API
    endpoints.MapRazorPages(); // Para o frontend, se aplicável
});

app.Run();
