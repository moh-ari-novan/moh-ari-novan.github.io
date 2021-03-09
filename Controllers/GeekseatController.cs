using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekSeat.Entities;
using GeekSeat.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeekSeat.Controllers
{
    public class GeekseatController : Controller
    {
        public IActionResult Index()
        {
            var model = new GeekseatViewModel()
            {
                FirstPerson = new Person(),
                SecondPerson = new Person()
            };
            return View(model);
        }

        [HttpPost]
        public ViewResult Result()
        {
            //Get Request Data
            var request = HttpContext.Request;

            //Create Variable
            int FirstDeathAge = Convert.ToInt32(request.Form["txtFirstDeathAge"]);
            int FirstDeathYear = Convert.ToInt32(request.Form["txtFirstDeathYear"]);
            int SecondDeathAge = Convert.ToInt32(request.Form["txtSecondDeathAge"]);
            int SecondDeathYear = Convert.ToInt32(request.Form["txtSecondDeathYear"]);

            //Initiate model
            var model = new GeekseatViewModel()
            {
                FirstPerson = new Person(FirstDeathAge, FirstDeathYear),
                SecondPerson = new Person(SecondDeathAge,SecondDeathYear)
            };

            model.AverageDeath = ((decimal)(model.FirstPerson.KilledPeopleByYear + model.SecondPerson.KilledPeopleByYear)/2);

            return View("Index", model);
        }
    }
}