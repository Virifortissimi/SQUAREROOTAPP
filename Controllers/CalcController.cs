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
            
                try
                {
                    if (Convert.ToInt32(firstNumber) < 0 || Convert.ToInt32(secondNumber) < 0)
                    {
                        string ErrorMessage = "Please insert a positive number!!";

                        ViewBag.ErrorMessageValue = ErrorMessage;
                    }
                    else
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
                        ViewBag.Result = highestSqrt;
                        ViewBag.numberOneValue = numberOne;
                        ViewBag.numberTwoValue = numberTwo;
                        ViewBag.firstSqrtValue = firstSqrt;                    
                        ViewBag.secondSqrtValue = secondSqrt;
                    }
                }
                catch (FormatException ex)
                {
                    // Console.WriteLine(ex.Message);
                    var exceptionValue = ex.Message;
                    ViewBag.FormatError = "Please Insert a number instead. " + exceptionValue;
                }
            
            return View();
        }
    }
}