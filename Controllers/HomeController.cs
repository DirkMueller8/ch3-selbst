﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ch3_selbst.Models;

namespace ch3_selbst.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}