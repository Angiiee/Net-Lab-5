using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.entity
{
    public class GoogsInsurance : InsuranceObligation
    {
        private GoodsType type;

        public GoogsInsurance()
        {
        }

        public GoogsInsurance(GoodsType type, DateTime contractOpeningDate, decimal risk, decimal contractSum, decimal monthPayment, int period) : base(contractOpeningDate, risk, contractSum, monthPayment, period)
        {
            Type = type;
        }

        internal GoodsType Type { get => type; set => type = value; }

        public override bool Equals(object obj)
        {
            var insurance = obj as GoogsInsurance;
            return insurance != null &&
                   base.Equals(obj) &&
                   Type == insurance.Type;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Type);
        }

        public override string ToString()
        {
            return "Googs Insurance " + base.ToString();
        }

        public enum GoodsType { Flat, Car };
    }
}
