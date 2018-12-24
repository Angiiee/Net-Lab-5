using Lab5.collection;
using Lab5.entity;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        Derivative derivative;

        [SetUp]
        public void Setup()
        {
            derivative = new Derivative();
            //string personName, DateTime contractOpeningDate, decimal risk, decimal contractSum, decimal monthPayment, int period
            derivative.InsuranceDerivative.Add(new LifeInsurance("Ivan Ivanov", new DateTime(2010, 8, 18), 0.25m, 100, 23, 15));
            derivative.InsuranceDerivative.Add(new LifeInsurance("Peter Ivanov", new DateTime(2010, 8, 18), 0.2m, 100, 23, 15));
            //GoodsType type, DateTime contractOpeningDate, decimal risk, decimal contractSum, decimal monthPayment, int period
            derivative.InsuranceDerivative.Add(new GoogsInsurance(GoogsInsurance.GoodsType.Flat, new DateTime(2010, 8, 18), 0.27m, 100, 23, 15));
            derivative.InsuranceDerivative.Add(new GoogsInsurance(GoogsInsurance.GoodsType.Car, new DateTime(2010, 8, 18), 0.12m, 100, 23, 15));
            derivative.InsuranceDerivative.Add(new GoogsInsurance(GoogsInsurance.GoodsType.Flat, new DateTime(2010, 8, 18), 12m, 100, 23, 15));
        }

        [Test]
        public void TestSort()
        {
            derivative.InsuranceDerivative.Sort();
            Assert.AreEqual(new GoogsInsurance(GoogsInsurance.GoodsType.Car, new DateTime(2010, 8, 18), 0.12m, 100, 23, 15), derivative.InsuranceDerivative[0]);
        }

        [Test]
        public void TestGetDerivativeWithRiskLower()
        {
            Assert.AreEqual(3, derivative.GetDerivativeWithRiskLower(0.26m).InsuranceDerivative.Count);
        }
    }
}