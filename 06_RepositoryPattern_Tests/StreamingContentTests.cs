using System;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        //each test method has a void, (testm + tab tab will build it out TestMethod structure)
        public void SetTitle_ShouldGetCorrectString()
        {
            // Arrange
            //creating a way to test setting the title string
            StreamingContent content = new StreamingContent();

            // Acting
            content.Title = "Toy Story";

            //create variables to compare the output
            string expected = "Toy Story";
            string actual = content.Title;

            // Assert
            //assert used to test if the expected and acual are true
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        //making a row of data to test multiple cases at once
        //arguments being passed into the method
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.R, false)]
        //add the parameters to pass them through into the tested logic(make rating and expectedFamilyFriendly variables to test cases)
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedFamilyFriendly)
        {
            // Arrange
            //assign a new streaing content and maturity rating
            StreamingContent content = new StreamingContent();

            // Act
            //setting it to rating to test both G and R
            content.MaturityRating = rating;

            // Assert
            //change it to the other parameter of expectedFamilyFriendly to check bool and content
            Assert.AreEqual(expectedFamilyFriendly, content.IsFamilyFriendly);
            //Assert.IsTrue is another method but would only work with true values

        }
    }
}
