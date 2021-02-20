using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CoreCross.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
        public Result(bool succes,string messange):this(succes)
        {

        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}
