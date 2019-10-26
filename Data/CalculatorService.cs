using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowCase.Data
{
    public class CalculatorService
    {
        public Task<double> Calculate(double a, double b)
        {
            return Task.FromResult(a * b);
        }
    }
}
