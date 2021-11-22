using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ODDD.Domain.Entities;
using ODDD.Domain.Repositories;
using ODDD.WinForm.ViewModels;

namespace ODDDTest.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var view_model = new WeatherLatestViewModel(new WeatherMock());
            Assert.AreEqual("", view_model.AreaIdText);
            Assert.AreEqual("", view_model.TempertureText);

            view_model.AreaIdText = "1_1";
            view_model.Search();
            Assert.AreEqual("1_1", view_model.AreaIdText);
            Assert.AreEqual("test", view_model.TempertureText);

        }

        internal class WeatherMock : IWeatherRepository
        {
            public WeatherEntity GetData()
            {
                return new WeatherEntity("1_1","test");
            }
        }
    }
}
