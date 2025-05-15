using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Text;


[ApiController]
[Route("[controller]")]
public class GeradorSenhaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(int length = 12, bool uppercase = true, bool lowercase = true, bool numbers = true, bool special = true)
    {
        const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string lower = "abcdefghijklmnopqrstuvwxyz";
        const string num = "0123456789";
        const string specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?";

        var pool = new StringBuilder();
        if (uppercase) pool.Append(upper);
        if (lowercase) pool.Append(lower);
        if (numbers) pool.Append(num);
        if (special) pool.Append(specialChars);

        if (pool.Length == 0)
            return BadRequest("Selecione pelo menos um tipo de caractere.");

        var random = new Random();
        var senha = new string(Enumerable.Range(0, length)
            .Select(_ => pool[random.Next(pool.Length)]).ToArray());

        return Ok(senha);
    }
}
