using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.entity
{
    public class LifeInsurance : InsuranceObligation
    {
        private string personName;

        public LifeInsurance()
        {
        }

        public LifeInsurance(string personName, DateTime contractOpeningDate, decimal risk, decimal contractSum, decimal monthPayment, int period) : base(contractOpeningDate, risk, contractSum, monthPayment, period)
        {
            PersonName = personName;
        }

        public string PersonName { get => personName; set => personName = value; }

        public override bool Equals(object obj)
        {
            var insurance = obj as LifeInsurance;
            return insurance != null &&
                   base.Equals(obj) &&
                   PersonName == insurance.PersonName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), PersonName);
        }

        public override string ToString()
        {
            return "LifeInsurance " + base.ToString();
        }
    }
}
