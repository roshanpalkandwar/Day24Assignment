using Day24Assignment;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string firstName = "Snehil";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
            Console.WriteLine(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
           ValidUser user = new ValidUser();
            string lastName = "Verma";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string email = "SnehilSingh4888@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string mobileNumber = "91 9876543210";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string password = "Snehil@543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string firstName = "snehil";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string lastName = "verma";
            //Act
            bool result = user.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string email = "SnehilSinghgmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string mobileNumber = "91 0876543210";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string password = "snehil@#543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
    }
}