﻿namespace ChallengeApp2024.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestFloatAreNotEqual()
        {
            // arrenge
            float number3 = 3.2345f;
            float number4 = 4.3456f;

            // act


            // assert
            Assert.AreNotEqual(number3, number4);
        }

        [Test]
        public void StringAreNotEqual()
        {
            // arrenge
            string string1 = "Hubert";
            string string2 = "Michał";


            // act


            // assert
            Assert.AreNotEqual(string1, string2);
        }

        [Test]
        public void TestIntAreNotEqual()
        {
            // arrenge
            int number1 = 1;
            int number2 = 2;

            // act


            // assert
            Assert.AreNotEqual(number1, number2);
        }

    }
}
