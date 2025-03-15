using Asrfly.Core;
using Asrfly.Data;
using Asrfly.Data.SqlServer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asrfly.Tests {
    [TestClass]
    public class CategoriesEntityTest {
        IDataHelper<Categories> dataHelper;
        public CategoriesEntityTest() {
            dataHelper = new CategoriesEntity();
        }

        [TestMethod]
        public void AddTest() {
            // Arrange 
            Categories categories = new Categories {
                Name = "تحليل المشروع",
                Details = "الصنف الخاص في عملية تحليل المشروع",
                Type = "صرف",
                Balance = 1000,
                AddedDate = DateTime.Now,
            };

            // Act and Expt (Get)
            int act = dataHelper.Add(categories);
            int expt = 1;

            // Assert (Test)
            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void EditTest() {
            // Arrange 
            Categories categories = new Categories {
                Id = 1,
                Name = "تصميم المشروع",
                Details = "الصنف الخاص في عملية تصميم المشروع",
                Type = "صرف",
                Balance = 2000,
                AddedDate = DateTime.Now,
            };

            // Act and Expt (Get)
            int act = dataHelper.Edit(categories);
            int expt = 1;

            // Assert (Test)
            Assert.AreEqual(expt, act);
        }

        [TestMethod]
        public void GetAllDataTest() {
            // Act and Expt (Get)
            var act = dataHelper.GetAllData();

            // Assert (Test)
            Assert.IsNotNull(act);
        }

        [TestMethod]
        public void SearchTest() {
            // Arrange
            var searchItem = "صرف";

            // Act and Expt (Get)
            var act = dataHelper.Search(searchItem);

            // Assert (Test)
            Assert.IsNotNull(act);
        }

        [TestMethod]
        public void FindTest() {
            // Arrange
            var id = 1;

            // Act and Expt (Get)
            var act = dataHelper.Find(id);

            // Assert (Test)
            Assert.IsNotNull(act);
        }
        [TestMethod]
        public void DeleteTest() {
            // Arrange
            var id = 1;

            // Act and Expt (Get)
            var act = dataHelper.Delete(id);

            // Assert (Test)
            Assert.AreEqual(1, act);
        }

    }
}
