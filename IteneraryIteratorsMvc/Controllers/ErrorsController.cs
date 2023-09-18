﻿using Microsoft.AspNetCore.Mvc;

namespace IteneraryIteratorsMvc.Controllers
{
	public class ErrorsController : Controller
	{

		[HttpGet("error/exception")]
		public IActionResult ServerError()
		{
			return View();
		}

		[HttpGet("error/http/{statusCode}")]
		public IActionResult HttpError(int statusCode)
		{
			return View(statusCode);
		}


	}
}
