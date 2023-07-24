using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benefit_Calculator
{
    class Salary
    {
        public double Income { get; set; }
        public double ISSS { get; set; }
        public double AFP { get; set; }
        public double Rent { get; set; }
        public double NetSalary { get; set; }

        public Salary(double Income)
        {
            this.Income = Income;

            SetISSS();
            SetAFP();
            SetRent();
            SetNetSalary();
        }

        private void SetISSS()
        {
            ISSS = (Income > 1000) ? 30 : (Income * 0.03);
        }

        private void SetAFP()
        {
            AFP = Income * 0.0725;
        }

        private void SetRent()
        {
            var discounts = Income - ISSS - AFP;

            Rent = discounts switch
            {
                double n when (n > 472 && n <= 895.24) => ((discounts - 472) * 0.1) + 17.67,
                double n when (n >= 895.25 && n <= 2038.10) => ((discounts - 895.24) * 0.2) + 60,
                double n when (n >= 2038.11) => ((discounts - 2038.1) * 0.3) + 288.57,
                _ => (double)0,
            };
        }

        private void SetNetSalary()
        {
            NetSalary = Income - ISSS - AFP - Rent;
        }
    }
}
