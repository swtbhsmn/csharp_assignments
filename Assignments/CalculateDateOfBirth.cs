using System;

namespace Assginments
{
    class CalculateDateOfBirth
    {
        public static void CalculateAgeCaller()
        {
            try
            {
                Console.Write("Enter Year:");
                int yyyy = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Month:");
                int mm = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Day:");
                int dd = Convert.ToInt32(Console.ReadLine());
                int[] userDob = UserDateOfBirth(new DateTime(yyyy, mm, dd));
                Console.WriteLine($"Years: {userDob[0]}, Months:{userDob[1]}, Days:{userDob[2]} ");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static int[] UserDateOfBirth(DateTime dob)
        {
            int[] dateOfBirthContainer = new int[3];
            DateTime today = DateTime.Today;
            int years = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            DateTime pastYearDate = dob.AddYears(years);
            int months = 0;

            try
            {
                for (int i = 1; i <= 12; i++)
                {
                    if (pastYearDate.AddMonths(i) == today)
                    {
                        months = i;
                        break;
                    }
                    else if (pastYearDate.AddMonths(i) >= today)
                    {
                        months = i - 1;
                        break;
                    }
                }
                int days = today.Subtract(pastYearDate.AddMonths(months)).Days;


                dateOfBirthContainer[0] = years;
                dateOfBirthContainer[1] = months;
                dateOfBirthContainer[2] = days;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return dateOfBirthContainer;
        }
    }
}
