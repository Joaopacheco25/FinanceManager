using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using WebApplication.Controllers;

namespace FinanceData.Tests
{
    public class AuthenticationControllerTests
    {
        private  AuthenticationController _authenticationController;
        private Mock<ILogger<AuthenticationController>> _loggerMock;

        [SetUp]
        public void Setup()
        {
            _loggerMock = new Mock<ILogger<AuthenticationController>>();
            _authenticationController = new AuthenticationController(_loggerMock.Object);
        }

        [Test]
        public async Task IsLoginOk_WhenUsenameAndPasswordAreNull_RetrunsBadRequest()
        {
            var result = await _authenticationController.Login(null, null) as StatusCodeResult;

            Assert.AreEqual(400, result.StatusCode);
        }
        
        [Test]
        public async Task IsLoginOk_WhenOnlyUsenameAreNull_RetrunsBadRequest()
        {
            var result = await _authenticationController.Login(null, null) as StatusCodeResult;

            Assert.AreEqual(400, result.StatusCode);
        }
        
        [Test]
        public async Task IsLoginOk_WhenOnlyPasswordAreNull_RetrunsBadRequest()
        {
            var result = await _authenticationController.Login(null, null) as StatusCodeResult;

            Assert.AreEqual(400, result.StatusCode);
        }
        
        [Test]
        public async Task IsRegisterOk_WhenUserObjectIsNull_RetrunsBadRequest()
        {
            var result = await _authenticationController.Register(null) as StatusCodeResult;

            Assert.AreEqual(400, result.StatusCode);
        }
    }
}