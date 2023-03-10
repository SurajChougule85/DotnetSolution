using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace tflstore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        Console.WriteLine("Products Controller instance initialized......");
        _logger = logger;
    }
}