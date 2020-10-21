using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        //one of many many patterns 
        //repository pattern is used to make the CRUD pattern and store all the StreamingContent in a Collection
        //use a list in this example to hold all the StreamingContent objects
        //We will create a class level vaiable(not like a propery w/ a get and set, but a variable local to the scope of the method)
        //Field is private variable, created below (underscore indicates that the variable is a field) 
        // which all methods in the class can access

        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
       
        // CRUD
        // CREATE
        //pass in StreamingContent as a parameter to access it inside the method
        public void AddContentToDirectory(StreamingContent content)
        {
            _contentDirectory.Add(content);
        }


        // READ
        // Get all streamingContent
        public List<StreamingContent> GetDirectory()
        {
            return _contentDirectory;
        }

        // Get one streamingContent By Title
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent item in _contentDirectory)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    return item;
                }
            }

            return null;
        }


        // UPDATE
        public bool UpdateExistingContent(StreamingContent updatedContent, string originalTitle)
        {
            // Find the target content by origonalTitle
            foreach (StreamingContent item in _contentDirectory)
            {
                StreamingContent content = GetContentByTitle(originalTitle);
                if(content != null)
                {
                    int itemIndex = _contentDirectory.IndexOf(content);
                    _contentDirectory[itemIndex] = updatedContent;
                    return true;
                }
                return false;


                if (item.Title.ToLower() == originalTitle.ToLower())
                {
                    // Update the target content with updatedContent properties/values
                    //item.Title = updatedContent.Title;
                    //item.Description = updatedContent.Description;
                    //item.MaturityRating = updatedContent.MaturityRating;
                    //item.ReleaseYear = updatedContent.ReleaseYear;
                    //item.StarRating = updatedContent.StarRating;
                    //item.Genre = updatedContent.Genre;

                    // another way to do above
                    // Find the index that item is at
                    int itemIndex = _contentDirectory.IndexOf(item);
                    // Slot in updatedContent into that index on the List
                    _contentDirectory[itemIndex] = updatedContent;

                    return true;
                }
            }

            return false;
        }


        // DELETE
        //access modifier, return type, name (parameters)
        public bool DeleteExistingContent(StreamingContent content)
        {
            return _contentDirectory.Remove(content);
        }

        // Delete Content by title
        // Method needs a title parameter, find content by title, if found then delete, return t/f if worked
        public bool DeleteContentByTitle(string title)
        {
            StreamingContent targetContent = GetContentByTitle(title);
            return DeleteExistingContent(targetContent);
        }

    }
}
