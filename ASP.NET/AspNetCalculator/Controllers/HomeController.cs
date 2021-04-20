using ASPNETCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCalculator.Controllers
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
			return View();
		}

		[HttpGet]
		public IActionResult Calc(int n1, int n2, string operation)
		{
			ViewData["N1"] = n1;
			ViewData["N2"] = n2;

			if (operation == "plus")
			{
				ViewData["ActionSymbol"] = '+';
				ViewData["Result"] = n1 + n2;
			}
			else if (operation == "minus")
			{
				ViewData["ActionSymbol"] = '-';
				ViewData["Result"] = n1 - n2;
			}
			else if (operation == "multiply")
			{
				ViewData["ActionSymbol"] = '*';
				ViewData["Result"] = n1 * n2;
			}
			else if (operation == "divide")
			{
				ViewData["ActionSymbol"] = '/';

				if (n2 == 0)
				{
					ViewData["Result"] = "DIVISION BY ZERO";

					return View("Result");
				}

				ViewData["Result"] = n1 / n2;
			}

			return View("Result");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
