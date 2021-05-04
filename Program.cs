using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietTrackor
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName; 
            int gender;
            int age, height, weight, workOutLevel, goalFatLoss, dietLength;
            int caloriesConsumed, coffeeConsumed, caloriesBurnt;
            double BMR , caloriesMaintenance , caloriesDeficitTarget , recommendedDailyCalories;
            int currentDayCount=2, daysRemaining ;
            double caloriesLost = 623.9, caloriesLostTotal = 1125.20, calorieDeficitAverage = 851.6, calorieDeficit = 854.85, fatLoss=250;
            double fatLossAverage = 245.63, fatLossSooFar = 236.54, fatLossExpected=290.6; 
            string x;
            BMR = 0;
            caloriesMaintenance = 0;

            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();

            Console.WriteLine("Enter your gender\n -Press 0 for male\n -Press 1 for female");
            gender = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your height (cm)");
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your weight (kg)");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your workout level\n -Press 1 for Light/No exercise\n -Press 2 for Light exercise\n -Press 3 for Moderate exercise\n -Press 4 for very active exercise\n -Press 5 for extra active exercise");
            workOutLevel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your fat loss goal (kg)");
            goalFatLoss = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your diet length (days)");
            dietLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your calories consumed (kcal)");
            caloriesConsumed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your coffee doses consumed");
            coffeeConsumed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your calories burnt (kcal)");
            caloriesBurnt = Convert.ToInt32(Console.ReadLine());



            if (gender == 0)
            {
                BMR = (10 * weight) + (6.25 * height) - (5 * age) + 5;
            }
            else if (gender == 1)
            {

                BMR = (10 * weight) + (6.25 * height) - (5 * age) - 161;
            }
            if (workOutLevel == 1)
                caloriesMaintenance = BMR * 1.2;
            else if (workOutLevel == 2)
                caloriesMaintenance = BMR * 1.375;
            else if (workOutLevel == 3)
                caloriesMaintenance = BMR * 1.55;
            else if (workOutLevel == 4)
                caloriesMaintenance = BMR * 1.725;
            else if (workOutLevel == 5)
                caloriesMaintenance = BMR * 1.9;

            caloriesDeficitTarget = ((goalFatLoss / 0.0128) * 100) / dietLength;

            recommendedDailyCalories = caloriesMaintenance - caloriesDeficitTarget;

            daysRemaining = dietLength - currentDayCount;

            Console.WriteLine("\n****Diet Report of " + userName + "****");
            Console.WriteLine("\nBMR = {0}\nCalories Maintenance = {1} kcal\nRecommended Daily Calories = {2} kcal\nCurrent Day Count = Day {3}\nRemaining Days = {4} days", BMR , caloriesMaintenance , recommendedDailyCalories , currentDayCount, daysRemaining);
            Console.WriteLine("\nCalories Lost = {0} kcal\nCalories Deficit Target = {1} kcal\nTotal Calories Lost = {2} kcal\nAverage Calorie Deficit = {3} kcal\nCalorie Deficit = {4}  " , caloriesLost , caloriesDeficitTarget , caloriesLostTotal , calorieDeficitAverage , calorieDeficit);
            Console.WriteLine("\nFat Loss = {0} g\nFat Loss Average = {1} g \nFat Loss So Far = {2} g\nFat Loss Expected = {3} g", fatLoss,fatLossAverage, fatLossSooFar,fatLossExpected);
            Console.WriteLine("\n*******************************\nPress x to continue");
            x = Console.ReadLine();
        }
    }
}
