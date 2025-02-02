using Data;
using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly UniversityContext _context;

        public OrderController(UniversityContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AddToOrder(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // ✅ Sprawdzenie, czy użytkownik jest zalogowany
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null)
            {
                return RedirectToAction("Login", "Account"); // Jeśli nie jest zalogowany, przekieruj do logowania
            }

            // ✅ Tworzenie zamówienia dla zalogowanego użytkownika
            var order = new OrderEntity
            {
                ProductId = product.Id,
                UserId = userId, // ✅ Używa ID aktualnie zalogowanego użytkownika
                OrderDate = DateTime.Now,
                IsPaid = false
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "Orders");
        }
    }
}
