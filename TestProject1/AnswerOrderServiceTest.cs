using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using api.Model;
using api.Services;


namespace TestProject1
{
    [TestClass]
    public class AnswerOrdersServiceTests
    {
        private OrdersService _ordersService;

        [TestInitialize]
        public void Setup()
        {
            _ordersService = new OrdersService();
        }

        [TestMethod]
        public void FetchOrders_FileNotFound_ReturnsEmptyList()
        {
            // Arrange
            var ordersFilePath = Path.Combine(AppContext.BaseDirectory, "orders.json");
            if (File.Exists(ordersFilePath))
            {
                File.Delete(ordersFilePath);
            }

            // Act
            var result = _ordersService.FetchOrders();

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FetchOrders_FileExists_ReturnsOrdersList()
        {
            // Arrange
            var ordersFilePath = Path.Combine(AppContext.BaseDirectory, "orders.json");
            var orders = new List<Order>
            {
                new Order { OrderId = "1", CompanyId = "C1", CustomerName = "Customer1", OrderDate = DateTime.Now, TotalAmount = 100 },
                new Order { OrderId = "2", CompanyId = "C2", CustomerName = "Customer2", OrderDate = DateTime.Now, TotalAmount = 200 }
            };
            var json = JsonSerializer.Serialize(orders);
            File.WriteAllText(ordersFilePath, json);

            // Act
            var result = _ordersService.FetchOrders();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("1", result[0].OrderId);
            Assert.AreEqual("2", result[1].OrderId);
        }

        [TestMethod]
        public void FilterByCompany_ValidCompanyId_ReturnsFilteredOrders()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { OrderId = "1", CompanyId = "C1", CustomerName = "Customer1", OrderDate = DateTime.Now, TotalAmount = 100 },
                new Order { OrderId = "2", CompanyId = "C2", CustomerName = "Customer2", OrderDate = DateTime.Now, TotalAmount = 200 }
            };

            // Act
            var result = _ordersService.FilterByCompany("C1", orders);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("1", result[0].OrderId);
        }

        [TestMethod]
        public void FilterByCompany_InvalidCompanyId_ReturnsEmptyList()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { OrderId = "1", CompanyId = "C1", CustomerName = "Customer1", OrderDate = DateTime.Now, TotalAmount = 100 },
                new Order { OrderId = "2", CompanyId = "C2", CustomerName = "Customer2", OrderDate = DateTime.Now, TotalAmount = 200 }
            };

            // Act
            var result = _ordersService.FilterByCompany("C3", orders);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void CalculateTotalAmount_ValidOrders_ReturnsTotalAmount()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { OrderId = "1", CompanyId = "C1", CustomerName = "Customer1", OrderDate = DateTime.Now, TotalAmount = 100 },
                new Order { OrderId = "2", CompanyId = "C2", CustomerName = "Customer2", OrderDate = DateTime.Now, TotalAmount = 200 }
            };

            // Act
            var result = _ordersService.CalculateTotalAmount(orders);

            // Assert
            Assert.AreEqual(300, result);
        }

        [TestMethod]
        public void CalculateTotalAmount_NoOrders_ReturnsZero()
        {
            // Arrange
            var orders = new List<Order>();

            // Act
            var result = _ordersService.CalculateTotalAmount(orders);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateTotalAmount_NullOrders_ReturnsZero()
        {
            // Act
            var result = _ordersService.CalculateTotalAmount(null);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
