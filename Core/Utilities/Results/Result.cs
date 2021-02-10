using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult'ın somut sınıfı
    public class Result : IResult
    {
        // sezen aksu güvercin
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //Overloading
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
