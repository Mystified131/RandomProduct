using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Square.Models;
using Square.ViewModels;

namespace Square.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    
        public IActionResult Result()
        {
            ResultViewModel resultViewModel = new ResultViewModel();

            resultViewModel.Error = "There is no value to asses a random product. Please return to the Home page.";

            return View(resultViewModel);
        }

        [HttpPost]
        public IActionResult Result(ResultViewModel resultViewModel)

        {
            if (ModelState.IsValid)
            {

                Testvalue qbert = new Testvalue("qbert", resultViewModel.testvalue);

                resultViewModel.randomproduct = qbert.RandomProduct(resultViewModel.testvalue);

                return View(resultViewModel);
            }

            return Redirect("/");
        }

    }





}
