using System;

namespace FairTaxPlan
{
    class FairTaxTest
    {
        static void Main(string[] args)
        {
            decimal housing;//to store user input as a decimal
            decimal food;//to store user input as a decimal
            decimal clothing;//to store user input as a decimal
            decimal transportation;//to store user input as a decimal
            decimal education;//to store user input as a decimal
            decimal healthCare;//to store user input as a decimal
            decimal vacations;//to store user input as a decimal
            decimal monthlyPreTax = 0;//to hold the sum of user input
            decimal monthlyTax = 0;//to hold the sum of fairtax amount
            string total;//to hold the sume of the user input and the fairtax amount

            FairTax userConsumption = null;//creating a fairtax object

            //getting housing totals
            Console.WriteLine("Please enter your monthly housing expense");//prompt for user input
            string input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out housing) || housing < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly housing expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();//storing new entry.
                continue;
            }
            userConsumption.HousingTax = housing;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += housing;//adding the cost of housing before taxes
            monthlyTax += userConsumption.HousingTax;//adding the taxes of housing to monthly taxes.
                                                     //getting food totals
            Console.WriteLine("Please enter your monthly food expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out food) || food < 0)
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly food expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.FoodTax = food;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += food;//adding the cost of food before taxes
            monthlyTax += userConsumption.FoodTax;//adding the taxes of food to monthly taxes.
                                                  //getting clothing totals
            Console.WriteLine("Please enter your monthly clothing expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out clothing) || clothing < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly clothingn expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.ClothingTax = clothing;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += clothing;//adding the cost of clothing before taxes
            monthlyTax += userConsumption.ClothingTax;//adding the taxes of clothing to monthly taxes.
                                                      //getting transportation totals
            Console.WriteLine("Please enter your monthly transportation expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out transportation) || transportation < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly transportation expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.TransporationTax = transportation;
            monthlyPreTax += transportation;//adding the cost of transportation before taxes
            monthlyTax += userConsumption.TransporationTax;//adding the taxes of transportation to monthly taxes.
                                                           //getting education totals
            Console.WriteLine("Please enter your monthly education expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out education) || education < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly education expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.EducationTax = education;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += education;//adding the cost of transportation before taxes
            monthlyTax += userConsumption.EducationTax;//adding the taxes of education to monthly taxes
                                                       //getting healthcare totals
            Console.WriteLine("Please enter your monthly health care expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out healthCare) || healthCare < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly health care expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.HealthCareTax = healthCare;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += healthCare;//adding the cost of healthcare before taxes
            monthlyTax += userConsumption.HealthCareTax;//adding the taxes of healthcare to monthly taxes.
                                                        //getting vacation totals
            Console.WriteLine("Please enter your monthly vacations expense");//prompt for user input
            input = Console.ReadLine();//temporarily storing user input as a string.
            while (!decimal.TryParse(input, out vacations) || vacations < 0)//validating the users input.
            {
                Console.WriteLine("INVALID ENTRY: Please enter your monthly vacations expense");//notifying user of error and prompt for new entry.
                input = Console.ReadLine();
            }
            userConsumption.VacationsTax = vacations;//storing the tax amount of the user input(the FairTax class calculates tax in set method)
            monthlyPreTax += vacations;//adding the cost of vacations before taxes
            monthlyTax += userConsumption.VacationsTax;//adding the taxes of vacations to monthly taxes.
            total = monthlyPreTax + monthlyTax;//adding monthly expense and taxes.

            //displaying the cost and the fairtax for each category and then displaying the total for the month.

            Console.WriteLine("\n--------------------ESTIMATED FAIRTAX--------------------");
            Console.WriteLine($"HOUSING:       {housing,10:C}\tFAIRTAX:{userConsumption.HousingTax,10:C}");
            Console.WriteLine($"FOOD:          {food,10:C}\tFAIRTAX:{userConsumption.FoodTax,10:C}");
            Console.WriteLine($"CLOTHING:      {clothing,10:C}\tFAIRTAX:{userConsumption.ClothingTax,10:C}");
            Console.WriteLine($"TRANSPORTATION:{transportation,10:C}\tFAIRTAX:{userConsumption.TransporationTax,10:C}");
            Console.WriteLine($"EDUCATION:     {education,10:C}\tFAIRTAX:{userConsumption.EducationTax,10:C}");
            Console.WriteLine($"HEALTHCARE:    {healthCare,10:C}\tFAIRTAX:{userConsumption.HealthCareTax,10:C}");
            Console.WriteLine($"VACATIONS:     {vacations,10:C}\tFAIRTAX:{userConsumption.VacationsTax,10:C}");

            Console.WriteLine($"\nMonthly SUBTOTAL: {monthlyPreTax,10:C} " +
                              $"\nMonthly FAIRTAX:  {monthlyTax,10:C} " +
                              $"\nMonthly TOTAL:    {total,10:C}");
        }
    }

}
