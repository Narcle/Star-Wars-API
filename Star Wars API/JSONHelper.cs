using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_API
{
    public class JSONHelper
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        static readonly HttpClient client = new HttpClient();

        public static async Task<Planet> GetPlanet(int PlanetID)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            Planet myDeserializedClass = new Planet();

            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/planets/" + PlanetID.ToString() + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);

                myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
        public static async Task<People> GetPeople(int PeopleID)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            People myDeserializedClass = new People();

            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/people/" + PeopleID.ToString() + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);

                myDeserializedClass = JsonConvert.DeserializeObject<People>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }
        public static async Task<Species> GetSpecies(int ID)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            Species myDeserializedClass = new Species();

            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/species/" + ID.ToString() + "/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                myDeserializedClass = JsonConvert.DeserializeObject<Species>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

        public static async Task<AllSpecies> GetAllSpecies()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            AllSpecies myDeserializedClass = new AllSpecies();

            try
            {
                using HttpResponseMessage response = await client.GetAsync("http://swapi.dev/api/species/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                myDeserializedClass = JsonConvert.DeserializeObject<AllSpecies>(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            return myDeserializedClass;
        }

    }
}
