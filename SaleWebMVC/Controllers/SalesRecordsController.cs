﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMVC.Controllers
{
	public class SalesRecordsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
