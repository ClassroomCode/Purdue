﻿using EComm.Core;
using EComm.Infrastructure;
using EComm.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EComm.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IRepository repository, 
            ILogger<HomeController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // Interfaces
        // Explicit Dependencies Principle
        // Dependency Injection
        // Program to an interface, not an implementation

        public async Task<IActionResult> Index()
        {
            var products = await _repository.GetAllProducts();

            return Content($"Number of Products: {products.Count()}");
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