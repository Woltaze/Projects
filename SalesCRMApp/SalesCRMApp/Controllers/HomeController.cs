using Microsoft.AspNetCore.Mvc;
using SalesCRMApp.Models;
using System.Diagnostics;
using System.Text;

namespace SalesCRMApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public FileResult Export()
        {
            string[] columnNames = new string[] { "Id", "FirstName", "LastName", "Mobile", "Email", "Source" };
            var sales = new WordList().SalesList;

            string word = string.Empty;

            foreach (string columnName in columnNames)
            {
                word += columnName + ',';
            }

            word += "\r\n";

            foreach (var sale  in sales)
            {
                word += sale.Id.ToString().Replace(",", ";") + ',';
                word += sale.FirstName.Replace(",", ";") + ',';
                word += sale.LastName.Replace(",", ";") + ',';
                word += sale.Mobile.Replace(",", ";") + ',';
                word += sale.Email.Replace(",", ";") + ',';
                word += sale.Source.Replace(",", ";") + ',';

                word += "\r\n";
            }

            byte[] bytes = Encoding.ASCII.GetBytes(word);
            return File(bytes, "application/vnd.ms-word", "Emp.doc");

        }

        public IActionResult Index()
        {
            return View();
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