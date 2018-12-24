using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.entity
{
    public class InsuranceObligation : IComparable
    {
        private DateTime contractOpeningDate;
        private decimal risk;
        private decimal contractSum;
        private decimal monthPayment;
        private int period;

        public DateTime ContractOpeningDate { get => contractOpeningDate; set => contractOpeningDate = value; }
        public decimal Risk { get => risk; set => risk = value; }
        public decimal ContractSum { get => contractSum; set => contractSum = value; }
        public decimal MonthPayment { get => monthPayment; set => monthPayment = value; }
        public int Period { get => period; set => period = value; }

        public InsuranceObligation()
        {
        }

        public InsuranceObligation(DateTime contractOpeningDate, decimal risk, decimal contractSum, decimal monthPayment, int period)
        {
            ContractOpeningDate = contractOpeningDate;
            Risk = risk;
            ContractSum = contractSum;
            MonthPayment = monthPayment;
            Period = period;
        }

        public override bool Equals(object obj)
        {
            var obligation = obj as InsuranceObligation;
            return obligation != null &&
                   ContractOpeningDate == obligation.ContractOpeningDate &&
                   Risk == obligation.Risk &&
                   ContractSum == obligation.ContractSum &&
                   MonthPayment == obligation.MonthPayment &&
                   Period == obligation.Period;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ContractOpeningDate, Risk, ContractSum, MonthPayment, Period);
        }

        public override string ToString()
        {
            return "ContractOpeningDate - " + ContractOpeningDate + " Risk - " + Risk + " ContractSum - " + ContractSum + " MonthPayment - " + MonthPayment + " Period - " + Period;
        }

        public int CompareTo(object obj)
        {
            InsuranceObligation itemToCompare = obj as InsuranceObligation;
            if (itemToCompare.Risk < Risk)
            {
                return 1;
            }
            if (itemToCompare.Risk > Risk)
            {
                return -1;
            }
            return 0;
        }
    }
}
