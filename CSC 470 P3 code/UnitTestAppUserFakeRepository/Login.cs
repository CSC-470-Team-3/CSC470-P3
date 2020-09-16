using CSC_470_P3_code;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            //Arrange
            const string USERNAME = "JoeyHopkins";
            const string PASSWORD = "BadPassword2";
            FakeAppUserRepository AppUserRepository = new FakeAppUserRepository();


            //Act
            bool LoginStatus = AppUserRepository.Login(USERNAME, PASSWORD);


            //Assert
            Assert.IsTrue(LoginStatus == true);
        }



        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            //Arrange (Bad Trial)
            const string USERNAME = "JiminyCricket";
            const string PASSWORD = "IShouldNotExist";
            FakeAppUserRepository AppUserRepository = new FakeAppUserRepository();


            //Act
            bool LoginStatus = AppUserRepository.Login(USERNAME, PASSWORD);


            //Assert
            Assert.IsTrue(LoginStatus == true);
        }


    }
}
