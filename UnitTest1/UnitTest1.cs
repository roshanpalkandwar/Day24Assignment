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
            string firstName = "Roshan";
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
            string lastName = "Palkandwar";
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
            string email = "roshanpalkandwar1234@gmail.com";
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
            string mobileNumber = "91 9823760189";
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
            string password = "Roshan@543";
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
            string firstName = "roshan";
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
            string lastName = "palkandwar";
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
            string email = "RoshanPalkandwar.com";
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
            string mobileNumber = "91 0723760189";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserFistName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_FirstName()
        {
            try
            {
                //Arrange
                ValidUser2 user = new ValidUser2();
                string firstName = "Roshan";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_LastName()
        {
            try
            {
                //Arrange
                ValidUser2 user = new ValidUser2();
                string lastName = "Palkandwar";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Email()
        {
            try
            {
                //Arrange
                ValidUser2 user = new ValidUser2();
                string email = "roshangamil.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid email id.", e.Message);
            }
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_MobileNumber()
        {
            try
            {
                //Arrange
                 ValidUser2 user = new ValidUser2();
                string mobileNumber = "91 9823760188";
                //Act
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid mobile number.", e.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_Should_Throw_InvalidUserDetailException_Indicating_Invalid_Password()
        {
            try
            {
                //Arrange
                ValidUser2 user = new ValidUser2();
                string password = "roshan@#543";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (InvalidUserDetailException e)
            {
                //Assert
                Assert.AreEqual("Invalid password.", e.Message);
            }
        }

        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            ValidUser user = new ValidUser();
            string password = "roshan@#543";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue(string email)
        {
            //Arrange
            ValidUser user = new ValidUser();
            //Act
            bool result = user.ValidateEmail2(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue1(string email)
        {
            //Arrange
            ValidUser user = new ValidUser();
            //Act
            bool result = user.ValidateEmail2(email);
            //Assert
            Assert.IsTrue(result);
        }
    }
}