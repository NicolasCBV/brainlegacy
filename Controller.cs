using Microsoft.AspNetCore.Mvc;

// Definimos o namespace
namespace Brainlegacy.Controllers;

// Definimos a rota e herdamos a classe Controller
[Route("brainlegacy")]
public class BrainlegacyController : Controller {

  // Usamos HttpGet para definir rotas do metodo GET
  [HttpGet]
  public string Index() {
    return "Olá mundo!";
  }

  // Usamos HttpPost para definir rotas do metodo POST
  [HttpPost]
  public async Task<string> Mirror() {
    // Para acessar o corpo da requisição, podemos ler a stream em UTF8
	StreamReader reader = new StreamReader(Request.Body, System.Text.Encoding.UTF8);
    return await reader.ReadToEndAsync();
  }
}
