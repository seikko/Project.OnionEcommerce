using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CoreCross.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string messange) : base(true, messange)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
