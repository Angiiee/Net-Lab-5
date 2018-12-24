using Lab5.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.collection
{
    public class Derivative
    {
        private List<InsuranceObligation> insuranceDerivative;

        public Derivative()
        {
            insuranceDerivative = new List<InsuranceObligation>();
        }

        public Derivative(List<InsuranceObligation> insuranceDerivative)
        {
            InsuranceDerivative = insuranceDerivative;
        }

        public List<InsuranceObligation> InsuranceDerivative { get => insuranceDerivative; set => insuranceDerivative = value; }

        public override bool Equals(object obj)
        {
            var derivative = obj as Derivative;
            return derivative != null &&
                   EqualityComparer<List<InsuranceObligation>>.Default.Equals(InsuranceDerivative, derivative.InsuranceDerivative);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(InsuranceDerivative);
        }

        public override string ToString()
        {
            string result = "";
            foreach (InsuranceObligation item in InsuranceDerivative)
            {
                result += item.ToString();
            }
            return result;
        }

        public decimal CountDerivativeSum()
        {
            decimal sum = 0;
            foreach (InsuranceObligation item in InsuranceDerivative)
            {
                sum += item.MonthPayment * item.Period * item.Risk;
            }
            return sum;
        }

        public Derivative GetDerivativeWithRiskLower(decimal risk)
        {
            Derivative derivative = new Derivative();
            foreach (InsuranceObligation item in InsuranceDerivative)
            {
                if (item.Risk <= risk)
                {
                    derivative.InsuranceDerivative.Add(item);
                }
            }
            return derivative;
        }
    }
}
