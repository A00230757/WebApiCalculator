﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibraryCalculator;

namespace WebApiCalculator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorMultiplicationController : ControllerBase
    {
       /* [HttpGet]
        public double MultiplyTwoNumbers([FromQuery] double number1, [FromQuery] double number2)
        //this method of WebApi accept two numbers
        //in double data type
        //and use class library task subtracton already
        //made to return the result of subtraction
        {

            return CalculatorTasks.MultiplicationTask(number1, number2);
        }*/
    }
}
