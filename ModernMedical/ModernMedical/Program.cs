/*
 * User: jeff.crawford
 * Date: 11/13/2012
 * Time: 11:48 AM
 * Modern Medical C# Console Application Example Code.
 */
using System;

namespace ModernMedical
{
	class Program
	{
		public static void Main(string[] args)
		{
			  int divisableByThree = 0;
				int divisableByFive = 0;			
				string result = string.Empty;
								
				for(int index = 1; index <= 100; index++)
				{
				  divisableByThree = index % 3;		// if index is 3 then divisableByThree is set to 0.
					divisableByFive = index % 5;		// if index is 5 then divisableByFive is set to 0.
					
					if(divisableByThree == 0)
					{
						result = "Modern";
					}					
				
					if(divisableByFive == 0)
					{
						result = result + "Medical";
					}
					
					if(result == string.Empty)
					{
						result = index.ToString();
					}
					
					Console.WriteLine(result);
					
					result = string.Empty;
					
				}			
			
			//Console.ReadKey(true);		// Uncomment for testing.
		}
	}
}