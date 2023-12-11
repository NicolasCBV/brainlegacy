// Criamos uma instância de WebApplication,
// assim, podemos manipular a nossa API
var builder = WebApplication.CreateBuilder(args);

// Configura os services para os controllers, apesar
// de não usarmos nesta aplicação
builder.Services.AddControllers();

// Contruimos a nossa aplicação
var app = builder.Build();

// Mapeamos os controllers com base em seus endpoints
app.MapControllers();

// Executamos a aplicação
app.Run();
