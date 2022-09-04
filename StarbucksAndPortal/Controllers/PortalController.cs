using CoreLayer.Entities;
using CoreLayer.Repositories;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using RepositoryLayer.ConcreteRepositories;
using ServiceLayer.ConcreteService;
using ServiceLayer.ValidationRules;

namespace StarbucksAndPortal.Controllers
{
    public class PortalController : Controller
    {
        CustomerService _customerService = new CustomerService();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public async  Task<IActionResult> Index(Customer customer)
        {
            CustomerValidator validator = new CustomerValidator();
            ValidationResult results = validator.Validate(customer);

            if (results.IsValid)
            {
                customer.CopmanyName = "Portal";
                await _customerService.AddAsync(customer);
                return RedirectToAction("Index", "MainPage");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
