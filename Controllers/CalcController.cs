using System;
using Microsoft.AspNetCore.Mvc;

namespace SqrtApp.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public ActionResult Sqrt()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Sqrt(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            double firstSqrt = Math.Sqrt(numberOne);
            double secondSqrt = Math.Sqrt(numberTwo);
            double highestSqrt = 0;
            if (firstSqrt > secondSqrt)
            {
                highestSqrt = firstSqrt;
            }
            else
            {
                highestSqrt = secondSqrt;
            }

            ViewBag.highestSqrtValue = highestSqrt;
            ViewBag.numberOneValue = numberOne;
            ViewBag.numberTwoValue = numberTwo;
            ViewBag.firstSqrtValue = firstSqrt;
            ViewBag.secondSqrtValue = secondSqrt;

            return View();
        }
    }
}