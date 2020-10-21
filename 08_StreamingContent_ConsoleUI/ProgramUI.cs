using _06_RepositoryPattern_Repository;
using _08_StreamingContent_ConsoleUI.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_ConsoleUI
{
    public class ProgramUI
    {
        // private fields are located at the top for clarity as good code practice, 
        // are named with underscores to indicate that they're private fields
        private bool _isRunning = true;
        //bringing in the interface for use
        private readonly IConsole _console;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        // Constructor with injected IConsole dependancy
        public ProgramUI(IConsole console)
        {
            // Assigning our injected IConsole to our IConsole field
            _console = console;
        }



        //This is the entry point to our UI, it starts our user interface
        public void StartRun()
        {
            //adding seed here to add and run for tests/trial on the code running
            SeedContentList();
            // this is to start the application
            // Call RunMenu to get it as it starts
            RunMenu();
        }


        
        // This method has the task of running the menu 

        private void RunMenu()
        {
           
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }
        }

        private string GetMenuSelection()
        {
            _console.WriteLine(
                "Welcome to the Streaming Content Management!\n" +
                "Select Menu Item:\n" +
                "1. Show All Streaming Content\n" +
                "2. Find Streaming Content By Title\n" +
                "3. Add New Streaming Content\n" +
                "4. Update Existing Streaming Content\n" +
                "5. Remove Streaming Content\n" +
                "6. Exit");

            string userInput = _console.ReadLine();
            return userInput;
            
        }

        //building out a start menu to be in the console as it open
        private void OpenMenuItem(string userInput)
        {
            _console.Clear();
            switch (userInput)
            {
                case "1":
                    // show all content
                    DisplayAllContent();
                    break;
                case "2":
                    // Find content by title
                    DisplayContentByTitle();
                    break;
                case "3":
                    // Add new content
                    CreateNewContent();
                    break;
                case "4":
                    // Update content
                case "5":
                    // Remove content
                case "6":
                    // Exit
                    _isRunning = false;
                    //changing it to return will close the code block and exit properly instead of allowing a return to menu option 
                    return;
                default:
                    //invalid selection
                    _console.WriteLine("Invalid input.");
                    return;
            }

            _console.WriteLine("Press any key to return to the menu...");
            _console.ReadKey();
        }
        
        // Show All Content, using private to use within only this class with the switch case
        private void DisplayAllContent()
        {
            // Get content
            // Go to the repository and get the directory
            List<StreamingContent> listOfContent = _streamingRepo.GetDirectory();

            // Display the content
            foreach (StreamingContent content in listOfContent)
            {
                _console.WriteLine($"{content.Title} {content.Description}");
            }
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Genre: {content.Genre}\n" +
                $"Stars: {content.StarRating}\n" +
                $"Maturity Rating: {content.MaturityRating}\n" +
                $"Family Friendly: {(content.IsFamilyFriendly ? "Yes, it is!" : "No, it is not.")}\n");
        }

        // Find Content By Title
        private void DisplayContentByTitle()
        {
            // Promt the user to give us a title
            // .Write allows user to type on the same line, the line both writes then reads
            _console.Write("Please enter the title you wish to find:");

            // Get and store the users input
            string title = _console.ReadLine();

            // Find the matching content in the repository
            StreamingContent searchResult = _streamingRepo.GetContentByTitle(title);

            // Display the content to the console if found
            if (searchResult != null)
            {
                DisplayContent(searchResult);
            }

            // If there's no content cound, go ahead and say so
            else
            {
                _console.WriteLine("Invalid title. Could not find any results.");
            }
        }

        //Add New Content
        public void CreateNewContent()
        {
            // Gather values for all properties for the StreamingContent object 
            // Title
            _console.WriteLine("Enter a title: ");
            string title = _console.ReadLine();

            // Description
            _console.WriteLine("Enter a description: ");
            string description = _console.ReadLine();

            // MaturityRating
            MaturityRating maturityRating = GetMaturityRating();

            // StarRating
            _console.Write("Enter the star rating (1-5): ");
            // maybe refactor later so it won't break when not given a #
            double starRating = double.Parse(_console.ReadLine());

            // ReleaseYear
            _console.Write("Enter the release year: ");
            int releaseYear = int.Parse(_console.ReadLine());

            // GenreType
            GenreType genre = GetGenreType();

            // Construct a StreamingContent object given the above values
            StreamingContent newContent = new StreamingContent(title, description, maturityRating, starRating, releaseYear, genre);

            // Add the StreamingContent object to the repository ("Save" the content)
            _streamingRepo.AddContentToDirectory(newContent);
        }

        private MaturityRating GetMaturityRating()
        {
            _console.WriteLine("Select a Maturity Rating:\n" +
               "1. G\n" +
               "2. PG\n" +
               "3. TV Y\n" +
               "4. PG13\n" +
               "5. R\n" +
               "6. NC17\n" +
               "7. TV PG\n" +
               "8. TV 14\n" +
               "9. TV MA");

            string maturityString = _console.ReadLine();

            while (true)
            { 
                switch (maturityString)
                {
                    case "1":
                    case "g":
                        return MaturityRating.G;
                    case "2":
                        return MaturityRating.PG;
                    case "3":
                        return MaturityRating.TV_Y;
                    case "4":
                        return MaturityRating.PG13;
                    case "5":
                        return MaturityRating.R;
                    case "6":
                        return MaturityRating.NC17;
                    case "7":
                        return MaturityRating.TV_PG;
                    case "8":
                        return MaturityRating.TV_14;
                    case "9":
                        return MaturityRating.TV_MA;
                }

                _console.WriteLine("Invalid selection. Please try again.");
            }
        }

        private GenreType GetGenreType()
        {
            _console.WriteLine("Select a Genre:\n" +
                "1. Action/Adventure\n" +
                "2. Action\n" +
                "3. Thriller\n" +
                "4. Horror\n" +
                "5. Comedy\n" +
                "6. Bromance\n" +
                "7. Mystery\n" +
                "8. SciFi");

            while (true)
            {
                // One working version
                //string genreString = _console.ReadLine();
                //int genreId = int.Parse(genreString);
                //GenreType genre = (GenreType)genreId - 1;
                //return genre;

                // Version Two Long Way 
                string genreString = _console.ReadLine();
                bool parseResult = int.TryParse(genreString, out int parsedNumber);
                if(parseResult)
                {
                    GenreType genre = (GenreType)parsedNumber - 1;
                    return genre;
                }

                // Version Two the Short Way
                //if (int.TryParse(_console.ReadLine(), out int genreId))
                //{
                //    return (GenreType)genreId - 1;
                //}

                _console.WriteLine("Invalid selection, please try again.");
            }
        }

        // Update Content

        // Remove Content


        //Seed content is typically "planted" by the program to give data to the database for use, 
        //prior to the end user adding in any content to the database
        //object inintialization syntax can be used but we will be using the contructor this time

        private void SeedContentList()
        {
            StreamingContent rubber = new StreamingContent("Rubber", "Tyre comes to life and kills people.", MaturityRating.R, 5.8, 2010, GenreType.Thriller);
            StreamingContent toyStory = new StreamingContent("Toy Story", "Wonderful bromance between toys.", MaturityRating.G, 10, 1995, GenreType.Bromance);
            StreamingContent helloKitty = new StreamingContent("Hello Kitty Island Adventure", "Hello Kitty strikes again.", MaturityRating.PG, 8, 2010, GenreType.ActionAdventure);

            _streamingRepo.AddContentToDirectory(rubber);
            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(helloKitty);
        }
    }
}
