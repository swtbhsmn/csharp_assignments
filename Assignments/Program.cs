using System;

namespace Assginments
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int choice;
                Console.Write("Type 1: For Word Frequency Problem.\n" +
                              "Type 2: For Calculate Date of Birth.\n" +
                              "Type 3: For Remove Words From Text.\n" +
                              "Type 4: For Json to List\n" +
                              "Type 5: For Google custom search v1\n" +
                              "Type 6: For Supermarket Order\n" +
                              "Enter Your Choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (choice)
                {
                    case 1:
                        WordFrequency.WordFrequencyCaller();
                        break;
                    case 2:
                        CalculateDateOfBirth.CalculateAgeCaller();
                        break;
                    case 3:
                        StopWordRemove.StopWordRemoveCaller();
                        break;
                    case 4:
                        JsonToList.GetJsonFile("C:\\Datagrokr\\c#\\Assignments\\Assignments\\Share\\data.json");
                        break;
                    case 5:
                        HttpRequestToGoogle.ShowUrlResult();
                        break;
                    case 6:
                        Supermarket.SupermarketCaller();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}
