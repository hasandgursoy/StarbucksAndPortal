using CoreLayer.AbstractService;
using CoreLayer.DTOs;
using CoreLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer;
using RepositoryLayer.ConcreteRepositories;
using ServiceLayer.ConcreteService;
using ServiceLayer.ValidationRules;

namespace StarbucksAndPortal.Controllers
{
    public class StarbucksController : Controller
    {

        MernisControlService _mernisControl = new MernisControlService();
        CustomerService _customerService = new CustomerService();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(MernisDto mernisDto)
        {
            MernisDtoValidator validator = new();
            ValidationResult validateResult = validator.Validate(mernisDto);

            var result = await _mernisControl.IsTheCustomerRegisteredInMernis(mernisDto);



            if (result && validateResult.IsValid)
            {
                Customer customer = new()
                {
                    Name = mernisDto.Name,
                    Surname = mernisDto.Surname,
                    Email = mernisDto.Email,
                    Password = mernisDto.Password,
                    CopmanyName = "Starbucks"

                };

                await _customerService.AddAsync(customer);
                return RedirectToAction("Index", "MainPage");

            }
            else
            {
                foreach (var item in validateResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }



    }
}
