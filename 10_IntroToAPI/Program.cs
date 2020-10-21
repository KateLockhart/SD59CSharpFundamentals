using _10_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _10_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bring in HTTPClient so we can use Http Methods with "using System.Net.Http;"
            HttpClient httpClient = new HttpClient();

            // Send my first request
            // use method GetAsync to call on address as a string for use as argument
            //below is the same as httpClient.GetAsync("https://swapi.dev/api/people/1/");
            Task<HttpResponseMessage> getTask = httpClient.GetAsync("https://swapi.dev/api/people/1/");

            //Execute the task and get the result
            // assigning the result to variable "response"
            // using the result property to get the result value of the task
            // calling result is when it actually fires the code above; above is just the set up, not the fetch
            HttpResponseMessage response = getTask.Result;

            // Create and execute the async task
            // This does both line 20 and 26 at once
            HttpResponseMessage getResponse = httpClient.GetAsync("https://swapi.dev/api/people/1/").Result;

            // testing if response was successful
            // IsSuccessStatusCode is a property, has only a getter
            // diving into response with .Content and .ReadAsStringAsync method(needs .Result since it's async) to get actual string body of API, the response(JSON object)
            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                // after package installation, we can now dive into and call ReadAsAsync<>() (still needs .Result since it's async)
                // turns JSON response into something tangible to display the response to console
                Person personResponse = response.Content.ReadAsAsync<Person>().Result;

                // Can now dive in and call properties from class Person for each individual data response
                Console.WriteLine(personResponse.Name);

                foreach(string starshipURL in personResponse.Starships)
                {
                    // Get request
                    HttpResponseMessage starshipResponse = httpClient.GetAsync(starshipURL).Result;
                    // Convert response to C# class
                    var starship = starshipResponse.Content.ReadAsAsync<Starship>().Result;
                    // Utilizing that class and it's properties
                    Console.WriteLine(starship.Name + " " + starship.Model);

                }
            }

            // Now we create a folder for the Models to store and organize the data in our project
            // We change how we read the string and interpret the content diferently to use our Person class
            // We then add NuGet package from Microsoft to help us process JSON data - new methods adding in the if above 


            // with the new built out SWAPIService methods
            // Now we can use the methods to call what is above
            SWAPIService service = new SWAPIService();

            Person personTwo = service.GetPersonAsync("https://swapi.dev/api/people/10/").Result;
            if(personTwo != null)
            {
                Console.WriteLine(personTwo.Name);
                Console.WriteLine(personTwo.Starships.Count);

                foreach (var starshipUrl in personTwo.Starships)
                {
                    var starship = service.GetStarshipAsync(starshipUrl).Result;
                    Console.WriteLine(starship.Name);
                }
            }

            // using the generic async method we created
            Person genericPerson = service.GetAsync<Person>("https://swapi.dev/api/people/6/").Result;
            if (genericPerson != null)
            {
                Console.WriteLine(genericPerson.Name);
            }
            else
            {
                Console.WriteLine("Target object does not exist.");
            }

            Console.ReadLine();
        }
    }
}
