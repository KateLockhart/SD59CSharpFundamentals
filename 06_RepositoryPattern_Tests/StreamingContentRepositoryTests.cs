using System;
using System.Collections.Generic;
using _06_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        //Field is again used to bring in a property w/out get and set; it's another name for a variable 
        //Used to allow the test to have access to the content and repository 
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        
        [TestInitialize]
        public void Arrange()
        {
            // initialize and set up new instances
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);
        
            _repo.AddContentToDirectory(_content);
        }


        [TestMethod]
        //testing adding and reading directory
        public void GetDirectory_ShouldRetunCorrectCollection()
        {
            // Arrange --> set up the playing field, making the structure for what's to be tested
            StreamingContentRepository repo = new StreamingContentRepository();
            StreamingContent orange = new StreamingContent();

            repo.AddContentToDirectory(orange);

            // Act --> Get or run the code that we want to test
            List<StreamingContent> directory = repo.GetDirectory();

            bool directoryHasOrange = directory.Contains(orange);

            // Assert --> Using the Assert class to verify the expected outcome
            Assert.IsTrue(directoryHasOrange);
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            // Arrange
            // This will be replaced with our [TestInitialize] method
            // Arrange();

            //Act
            bool removeResult = _repo.DeleteExistingContent(_content);

            //Assert
            Assert.IsTrue(removeResult);
        }

        [DataTestMethod]
        [DataRow("rubber", true)]
        [DataRow("toy story", false)]
        public void DeleteByTitle_ShouldReturnCorrectBool(string title, bool expectedResult)
        {
            // Arrange [TestInitialize]

            // Act
            bool actualResult = _repo.DeleteContentByTitle(title);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
