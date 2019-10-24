using System;
using System.Collections.Generic;

namespace Lab_8___GetToKnowYourClassmates
{
	class Program
	{
		
		static void Main(string[] args)
		{
			//These are the lists for my exercise
			List<string> classmates = new List<string>();
			classmates.Add("Andy");
			classmates.Add("Nick");
			classmates.Add("Freddie");
			classmates.Add("Bob");
			classmates.Add("Horatio");

			List<string> homecities = new List<string>();
			homecities.Add("Antarctica");
			homecities.Add("The Land Before Time");
			homecities.Add("The Land Down Under");
			homecities.Add("Grand Rapids");
			homecities.Add("Miami: Vice City");

			List<string> favoriteFoods = new List<string>();
			favoriteFoods.Add("Shrimp on the Barbie");
			favoriteFoods.Add("Tacos");
			favoriteFoods.Add("Icicles");
			favoriteFoods.Add("Plant Based Diet");
			favoriteFoods.Add("Cocaine");

			List<string> favoriteBeer = new List<string>();
			favoriteBeer.Add("Red Stripe");
			favoriteBeer.Add("Breakfast Stout");
			favoriteBeer.Add("Bud Ice");
			favoriteBeer.Add("Fosters");
			favoriteBeer.Add("Corona");


			//Looking for user input to select someone in our classmates list.
			//Bool to run the entire program in a do-while
			bool studentselection = true;
			bool characteristicselection = true;
			//do while to run the entire program
			do
			{
				//Intro Statemnt with a for loop to list all our student options
				Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-5):");
				for (int i = 0; i < classmates.Count; i++)
				{
					Console.WriteLine($"{i + 1}. {classmates[i]}");
				}
				//setting the index to the student chosen by running the ParseString inside of the FindStudentValidationRange methods
				int index = FindStudentValidationRange("Which student would you like to learn more about? (enter a number 1-5): ", 0, classmates.Count);
				//printing out the chosen classmate
				Console.WriteLine($"Student {index} is {classmates[index - 1]}");
				//running a second do-while loop for the portion of the code about the classmate charateristics or to add another classmate
				do
				{
					//
					int classmateOrAddAnotherStudent = FindNumberValidationRange($"Would you like to know about 1. {classmates[index - 1]} or 2. add another student? Please select 1 or 2.");
					//if number is one, run the code below
					//Issue - Would like to put this into a method, but the lists are lost in the method.
					//If I put the Lists outside the main, the list.add dont seem to work.
					string userSelection = GetUserInput("Please enter 1 for hometown, 2 for favorite food, or 3 for favorite beer? ");
					switch (userSelection)
					{
						case "1":
							userSelection = ($"{homecities[index - 1]} is the hometown of {classmates[index - 1]}");
							break;
						case "2":
							userSelection = ($"{favoriteFoods[index - 1]} is the Favorite Food of {classmates[index - 1]}");
							break;
						case "3":
							userSelection = ($"{favoriteBeer[index - 1]} is the Favorite Beer of {classmates[index - 1]}");
							break;
						default:
							userSelection = GetUserInput(userSelection);
							break;
					}
					Console.WriteLine(userSelection);
					//Ask the User if they want to go again.
					string repeat = GetUserInput($"Would you like to know something else about this classmate? (y/n)");
					if (repeat == "y")
					{
						characteristicselection = true;
					}
					else
					{
						characteristicselection = false;
					}

				} while (characteristicselection);

				string secondRepeat = GetUserInput("Would you like to try a different classmate? (y/n)");
				if (secondRepeat == "y")
				{
					studentselection = true;
				}
				else
				{
					studentselection = false;
				}
			}
			while (studentselection);
			Console.WriteLine("Ok, have a great day then!");
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
		public static int FindNumberValidationRange(string input, int number)
		{
			int numberSelectionForStudentOrList = ParseString(input);
			if (number == 1)
			{
				//run code above
			}
			else
			{
				AddToList();
				break;
			}

		}
		//method to add a new classmate to the List classmates, would imagine you run multiple overloads to add to different lists
		public static void AddToList(List<string> classmates, string person)
		{
			Console.WriteLine("What is the new of the classmate you want to add?");
			string newClassmate = Console.ReadLine();
			classmates.Add(newClassmate);
		}
		//Method for try catch validation that I could not figure out how to work
		//public static string TryCatchValidationForSelection(string input)
		//{
		//	try  //if
		//	{
		//		int input1 = int.Parse(Console.ReadLine());
		//		string number = ($"Number {input1}");
		//		return number;
		//	}
		//	catch (FormatException)  //else if
		//	{
		//		string badInput = "Bad Input, we need a number for the selection.";
		//		return badInput;
		//	}
		//	catch (OverflowException) //else if
		//	{
		//		string overflowinput = "That number is too big";
		//		return overflowinput;
		//	}
		//	catch //else
		//	{
		//		throw new Exception("Something went wrong");
			}
		}
	}
}
//foreach (string word in (hometowns))
//{
//	homecities.Add(word);
//	for (int i = 0; i < homecities.Count; i++)
//	{
//		Console.WriteLine(homecities);
//	}
//}
