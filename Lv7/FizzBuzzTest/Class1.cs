using FizzBuzz;
using NUnit.Framework;
using System;

namespace FizzBuzzTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //arrange
        FizzBuzzer fizz = new FizzBuzzer();


        [TestCase("aaaa")]
        [TestCase("Palindrom")]
        [TestCase("I am Batman")]
        [TestCase("xxxxxxx")]
        [TestCase(" Miho,  Miki.")]
        [TestCase("x aaa .")]
        public void Convert_Palindrom(string input)
        {
            bool expected = false;
            //act
            bool actual = fizz.Check(input);
            //assrt
            Assert.AreEqual(expected, actual);
        }

        
    }
}