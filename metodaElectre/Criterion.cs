using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace metodaElectre
{
    public class Criterion
    {
        private double importanceCoefficient;
        public Criterion(double imp)
        {
            this.importanceCoefficient = imp;
        }

        public double getImportanceCoefficient()
        {
            return importanceCoefficient;
        }
        
        public override String ToString()
        {
            return importanceCoefficient + "";
        }
    }
}
