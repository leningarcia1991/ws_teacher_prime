﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using WsTeacher_Prime.Controllers.Seguridad;
using WsTeacher_Prime.Models;
using WsTeacher_Prime.Services.Interfaces;
using Xunit;

namespace ws_teacher_prime.Tests
{
    public class AuthControllerTests
    {
        private readonly AuthController _authController;
        private readonly Mock<IAuthService> _authServiceMock;

        public AuthControllerTests()
        {
            _authServiceMock = new Mock<IAuthService>();
            _authController = new AuthController(_authServiceMock.Object);
        }

        [Fact]
        public async Task Test_Login_ValidCredentials_ReturnsOkResult()
        {
            // Arrange
            var loginModel = new LoginModel { Username = "validUser", Password = "validPassword" };
            _authServiceMock.Setup(x => x.LoginAsync(It.IsAny<LoginModel>()))
                .ReturnsAsync("validToken");

            // Act
            var result = await _authController.Login(loginModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("validToken", okResult.Value);
        }

        [Fact]
        public async Task Test_Login_InvalidCredentials_ReturnsUnauthorizedResult()
        {
            // Arrange
            var loginModel = new LoginModel { Username = "invalidUser", Password = "invalidPassword" };
            _authServiceMock.Setup(x => x.LoginAsync(It.IsAny<LoginModel>())).ReturnsAsync((string)null);

            // Act
            var result = await _authController.Login(loginModel);

            // Assert
            Assert.IsType<UnauthorizedResult>(result);
        }

        [Fact]
        public async Task Test_Register_ValidUser_ReturnsOkResult()
        {
            // Arrange
            var registerModel = new RegisterModel { Username = "newUser", Password = "newPassword" };
            _authServiceMock.Setup(x => x.RegisterAsync(It.IsAny<RegisterModel>()))
                .ReturnsAsync(true);

            // Act
            var result = await _authController.Register(registerModel);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Test_Register_InvalidUser_ReturnsBadRequestResult()
        {
            // Arrange
            var registerModel = new RegisterModel { Username = "newUser", Password = "newPassword" };
            _authServiceMock.Setup(x => x.RegisterAsync(It.IsAny<RegisterModel>()))
                .ReturnsAsync(false);

            // Act
            var result = await _authController.Register(registerModel);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Test_RefreshToken_ValidToken_ReturnsOkResult()
        {
            // Arrange
            var tokenModel = new TokenModel { Token = "validToken" };
            var newToken = "newValidToken";

            _authServiceMock
                .Setup(service => service.RefreshTokenAsync(tokenModel.Token))
                .ReturnsAsync(newToken);

            // Act
            var result = await _authController.RefreshToken(tokenModel);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(newToken, okResult.Value);
        }

        [Fact]
        public async Task Test_RefreshToken_InvalidToken_ReturnsUnauthorizedResult()
        {
            // Arrange
            var tokenModel = new TokenModel { Token = "invalidToken" };

            _authServiceMock.Setup(service => service.RefreshTokenAsync(tokenModel.Token)).ReturnsAsync((string)null);

            // Act
            var result = await _authController.RefreshToken(tokenModel);

            // Assert
            Assert.IsType<UnauthorizedObjectResult>(result);
        }
    }
}
