using web_API.Models;
using web_API.Services;
using Microsoft.AspNetCore.Mvc;

// web_API is my a custom name
namespace web_API.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() =>
        PizzaService.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        // var infiere el tipo que viene de la deracha
        var pizza = PizzaService.Get(id);
        if(pizza == null)
            return NotFound();

        return pizza;
    }

    // POST action
    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
      PizzaService.Add(pizza);
      return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
      // This code will save the pizza and return a result
    }

    // PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();
              
        Pizza? existingPizza = PizzaService.Get(id);
        if(existingPizza is null)
            return NotFound();
      
        PizzaService.Update(pizza);           
      
        return NoContent();
    }

    // DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);
      
        if (pizza is null)
            return NotFound();
          
        PizzaService.Delete(id);
      
        return NoContent();
    }
}