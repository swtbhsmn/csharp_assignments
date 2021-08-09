using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Assginments
{
    class JsonToList
    {
        private class Employees
        {
            public string name { get; set; }
            public int age { get; set; }
            public string place { get; set; }

        }

        public static void GetJsonFile(string jsonFileLocation)
        {

            string jsonFilePath = @jsonFileLocation;



            if (File.Exists(jsonFilePath))
            {
                try
                {
                    Console.WriteLine("File found.");
                    string json = File.ReadAllText(jsonFilePath);
                    var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                    Console.WriteLine("Name:" + values["name"]);
                    Console.WriteLine("Age:" + values["age"]);
                    Console.WriteLine("Place:" + values["city"]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
            else
            {
                Console.WriteLine("File not found.");
            }



        }
    }
}
