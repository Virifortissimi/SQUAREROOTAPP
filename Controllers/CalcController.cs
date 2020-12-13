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
                    // Checking if Negative Number was inserted and Parsing Error Message to User
                    if (Convert.ToInt32(firstNumber) < 0 || Convert.ToInt32(secondNumber) < 0)
                    {
                        string ErrorMessage = "Please insert a positive number!!";

                        ViewBag.ErrorMessageValue = ErrorMessage;
                    }
                    else
                    {
                        //making Calculations
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
                    // Handling FormatExceptions and parsing message to User
                    var exceptionValue = ex.Message;
                    ViewBag.FormatError = "Try again. ";
                }
                catch (ArgumentNullException ex)
                {
                    var exceptionValueNullException = ex.Message;
                    ViewBag.FormatErrorNullException = "Please Insert a Value and try again";
                }
            return View();
        }
    }
}