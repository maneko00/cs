using System;
using DDD.Domain.Entities;
using DDD.Domain.Exceptions;
using DDD.Domain.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DDDTest.Tests
{
    [TestClass]
    public class ProductNumberHistoryViewModelTest
    {
        [TestMethod]
        public void 登録シナリオ()
        {
            var product_number_mock = new Mock<IProductNumberRipository>();

            var viewModel = new ProductNumberHistoryViewModel();
            viewModel.BaseProductNumberText.Is("");
            viewModel.SubProductNumberText.Is("");

            var ex = AssertEx.Throws<InputException>(() => viewModel.Save());
            ex.Message.Is("入力してください");

            viewModel.BaseProductNumberText = "000-0001";
            viewModel.SubProductNumberText = "000-0002";

            product_number_mock.Setup(x => x.Save(It.IsAny<ProductNumberEntity>())).
                Callback<ProductNumberEntity>(saveValue =>
                {
                    saveValue.BaseProductNumber.Is("000-0001");
                    saveValue.SubProductNumber.Is("000-0002");
                });
            viewModel.Save();



            //viewModel.Search();
            //viewModel.SearchProductNumberText.Is("010-1000");


        }
    }
}
