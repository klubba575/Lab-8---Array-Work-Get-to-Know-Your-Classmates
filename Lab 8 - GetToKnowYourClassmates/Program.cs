using System;

namespace Lab_8___GetToKnowYourClassmates
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] classmates = { "Andy", "Jack", "Jim", "Aaron", "Gomez" };
			string[] hometowns = { "Grand Rapids", "Antarctica", "The Land Before Time", "The Land Down Under", "Miami: Vice City" };
			string[] favoriteFoods = { "tacos", "icicles", "Plant Based Diet", "shrimp on the barbie", "cocaine" };
			string[] favoriteBeer = { "Breakfast Stout", "Bud Ice", "Rainwater", "Fosters", "Corona" };

			//Looking for user input to select someone in our classmates array.
			Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5):");

			int index = FindStudentValidationRange("Which student would you like to learn more about? (enter a number 1-5): ", 0, classmates.Length);
			Console.WriteLine($"Student {index} is {classmates[index - 1]}");
			do
			{

				Console.WriteLine($"What would you like to know about {classmates[index - 1]}?");

				string userSelection = GetUserInput("Please enter 1 for hometown, 2 for favorite food, 3 for favorite beer, or 4 for favorite band? ");
				string number = TryCatchValidationForSelection(userSelection);
			} while(runAgain()
		}
		public static string GetUserInput(string message)
		{
			Console.WriteLine(message);
			string input = Console.ReadLine();
			return input;
		}
		public static int ParseString(string input)
		{
			try
			{
				int number = int.Parse(Console.ReadLine());
				return number;
			}
			catch
			{
				return ParseString(input);
			}
		}
		public static int FindStudentValidationRange(string input, int min, int max)
		{
			int number = ParseString(input);
			if (number > min && number <= max)
			{
				return number;
			}
			else
			{
				return FindStudentValidationRange(input, min, max);
			}

		}
		public static string TryCatchValidationForSelection(string input)
		{
			try  //if
			{
				int input1 = int.Parse(Console.ReadLine());
				string number = ($"Number {input1}");
				return number;
			}
			catch (FormatException)  //else if
			{
				string badInput = "Bad Input, we need a number for the selection.";
				return badInput;
			}
			catch (OverflowException) //else if
			{
				string overflowinput = "That number is too big";
				return overflowinput;
			}
			catch //else
			{
				throw new Exception("Something went wrong");
			}
		}
		public static string runAgain(string input)
			{
				while (input == "y")
				{
				string startAgain = GetUserInput("Would you like to know something else about your classmate?");
				return startAgain;
				}
			} return "Ok, have a great day!"

		
	}
}
