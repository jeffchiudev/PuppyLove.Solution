using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PuppyLoveClient.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public string Mood { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }
        public string ImgUrl { get; set; }

        public static List<Dog> GetDogs()
        {
            var apiCallTask = ApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Dog> dogList = JsonConvert.DeserializeObject<List<Dog>>(jsonResponse.ToString());

            return dogList;
        }
    }
}