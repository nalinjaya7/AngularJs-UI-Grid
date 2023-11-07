using AngularJsUI_Grid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AngularJsUI_Grid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<OrderModel> models = new();
            models.Add(new OrderModel("Ord028", "Fewes", 1310.00m, DateTime.Now.AddDays(-22), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord027", "Kasun", 6707.00m, DateTime.Now.AddDays(-29), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord026", "Pradeep", 192.00m, DateTime.Now.AddDays(-30), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord025", "Prasanna", 6130.00m, DateTime.Now.AddDays(-30), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord024", "Banda", 6077.00m, DateTime.Now.AddDays(-33), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord023", "Yasith", 912.00m, DateTime.Now.AddDays(-43), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord022", "Lasantha", 1390.00m, DateTime.Now.AddDays(-44), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord021", "Uditha", 6277.00m, DateTime.Now.AddDays(-44), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord020", "Ishara", 128.00m, DateTime.Now.AddDays(-45), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord019", "Jhone", 8340.00m, DateTime.Now.AddDays(-47), OrderStatus.Order, 10.00m));
            models.Add(new OrderModel("Ord018", "Janaka", 99080.00m, DateTime.Now.AddDays(-50), OrderStatus.Cancelled, 12.00m));
            models.Add(new OrderModel("Ord017", "Parera", 55321.00m, DateTime.Now.AddDays(-50), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord016", "Milinda", 8786.00m, DateTime.Now.AddDays(-63), OrderStatus.Cancelled, 41.00m));
            models.Add(new OrderModel("Ord015", "Gihan", 987.00m, DateTime.Now.AddDays(-63), OrderStatus.SalesOrder, 200.00m));
            models.Add(new OrderModel("Ord014", "Mahela", 1990.00m, DateTime.Now.AddDays(-64), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord013", "Thirul", 607.00m, DateTime.Now.AddDays(-65), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord012", "Pradeep", 72.00m, DateTime.Now.AddDays(-65), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord011", "Prasanna", 1380.00m, DateTime.Now.AddDays(-65), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord010", "Nalin", 677.00m, DateTime.Now.AddDays(-66), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord009", "Thilina", 712.00m, DateTime.Now.AddDays(-68), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord008", "Anil", 130.00m, DateTime.Now.AddDays(-69), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord007", "Rohith", 677.00m, DateTime.Now.AddDays(-69), OrderStatus.SalesOrder, 8.00m));
            models.Add(new OrderModel("Ord006", "Ajith", 12.00m, DateTime.Now.AddDays(-70), OrderStatus.SalesOrder, 0.00m));
            models.Add(new OrderModel("Ord005", "Jhone", 6740.00m, DateTime.Now.AddDays(-71), OrderStatus.Order, 10.00m));
            models.Add(new OrderModel("Ord004", "Lalith", 98780.00m, DateTime.Now.AddDays(-72), OrderStatus.Cancelled, 12.00m));
            models.Add(new OrderModel("Ord003", "Parera", 321.00m, DateTime.Now.AddDays(-74), OrderStatus.Order, 2.00m));
            models.Add(new OrderModel("Ord002", "Kumar", 876.00m, DateTime.Now.AddDays(-75), OrderStatus.Cancelled, 41.00m));
            models.Add(new OrderModel("Ord001", "Gihan", 98767.00m, DateTime.Now.AddDays(-76), OrderStatus.SalesOrder, 200.00m));


            var options = Enum.GetValues<OrderStatus>().Where(h => h.ToString() != "All").ToList().Select(g => new { value = (g).ToString(), label = g.ToString() });
            var serializer = new Newtonsoft.Json.JsonSerializer();
            var stringWriter = new System.IO.StringWriter();
            using (var writer = new Newtonsoft.Json.JsonTextWriter(stringWriter))
            {
                writer.QuoteChar = '\'';   //replace double quotation using single quotation
                writer.QuoteName = false;
                serializer.Serialize(writer, options);
            }
            ViewData["OrderStatusjson"] = stringWriter.ToString();
            return View(models);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}