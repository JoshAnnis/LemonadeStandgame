using System;
using System.Linq;
using Lemonade_Stand_game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonStandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetsWeathercondition()
        {

            Weather weather = new Weather();
            //Arrange


            string[] Conditions = { "Rainy", "Partly Cloudy", "Stormy", " Clear and Sunny" };
            //Act
            weather.ConditionGenerator();

            //Assert
            Assert.IsTrue(Conditions.Contains(weather.condition));


            }
        [TestMethod]
        public void GetTemperature()
        {

            Weather weather = new Weather();
            Random random = new Random();

            //Act
            int[] temperatures = { random.Next(40, 101) };

            Assert.IsTrue(temperatures.Contains(weather.temperature));



        }













    }
    }

