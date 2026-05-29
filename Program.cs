/*
 * Created by SharpDevelop.
 * User: Byro
 * Date: 27/5/2026
 * Time: 3:49 pm
 * Place: PHILIPPINES
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;

namespace Checks_Even_or_Odd_Number
{
	class Program
	{
		public static void Main(string[] args)
		{
			int timer = 5;
			string userinput = "";
			double converted_num;
			
			while (true) 
			{
				Console.ResetColor();
				Console.Write("Use my Odd/Even Number checker?[yes/no]: ");
				string ans = Console.ReadLine().ToLower() ?? ""; //Yes NO YES NO -> yes/no
				if (ans == "yes")
				{
					Console.ResetColor();
					Console.WriteLine("Enter a number");
					userinput = Console.ReadLine();
					if (double.TryParse(userinput, out converted_num)) 
					{
						if (converted_num % 2 == 0) //[whole and even numbers goes here {2, 4, 6, 8, etc}]
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine(string.Format("{0}, was an even NUMBER", userinput));
							Console.WriteLine("Restarting...");
							Thread.Sleep(1500);
							Console.Clear();
						}
						else//all odd and with decimal point goes here[1.4, 3, 4.5, etc.]
						{
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine(string.Format("{0}, was an odd NUMBER", userinput));
							Console.WriteLine("Restarting...");
							Thread.Sleep(1500);
							Console.Clear();
						}
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Input a Number...");
						Console.WriteLine("Restarting");
						Thread.Sleep(1500);
						Console.Clear();
					}
					
				}
				else if (ans == "no")
				{
					while (timer > 0) {
						Console.Clear();
						Console.WriteLine(string.Format("Exiting in {0}", timer));
						Thread.Sleep(1000);
						timer--;
					}
					break;
				}
				
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Please Choose yes or no");
					Thread.Sleep(1500); //1.5s
					Console.Clear();
				}
			}
		}
	}
}
