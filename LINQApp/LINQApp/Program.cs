using System;
using Newtonsoft.Json;
using LINQApp.Classes;
using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }


        static void Questions ()
        {
            string fileData = System.IO.File.ReadAllText("../data.json");
            Data data = JsonConvert.DeserializeObject<Data>(fileData);

            var query = from places in data.Features select places.Properties.Neighborhood;

            foreach (var item in query)
            {

            }
        }
    }
}
