using Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

/// <summary>
/// [UnitOfWork_StateUnderTest_ExpectedBehavior]
/// </summary>
namespace Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void CalculateRewardPoints_GivenAnAmountOf100ForSilverAccount_Return10Points()
        {
            //Arrange
            var account = new Account(AccountType.Silver);

            //Act
            var actual = account.CalculateRewardPoints(100);

            // Assert
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void CalculateRewardPoints_GivenAnAmountOf100ForGoldAccount_Return20Points()
        {
            //Arrange
            var account = new Account(AccountType.Gold);

            //Act
            var actual = account.CalculateRewardPoints(100);

            // Assert
            Assert.AreEqual(20, actual);
        }

        [TestMethod]
        public void CalculateRewardPoints_GivenAnAmountOf100ForGoldAccountThatHasBalanceOf100_Return20Points()
        {
            //Arrange
            var account = new Mock<Account>(AccountType.Gold);
            account.Setup(a => a.Balance).Returns(100);

            //Act
            var actual = account.Object.CalculateRewardPoints(100);

            // Assert
            Assert.AreEqual(20, actual);
        }

        [TestMethod]
        public void CalculateRewardPoints_GivenAnAmountOf100ForPlatinumAccountThatHasBalanceOf100_Return51Points()
        {
            //Arrange
            var account = new Mock<Account>(AccountType.Platinum);
            account.Setup(a => a.Balance).Returns(100);

            //Act
            var actual = account.Object.CalculateRewardPoints(100);

            // Assert
            Assert.AreEqual(51, actual);
        }
    }
}
