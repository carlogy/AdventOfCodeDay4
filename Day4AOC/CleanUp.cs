using System;


namespace Day4AOC
{
	public class CleanUp
	{
		public static int Groups()
		{
			Console.Write("Input PuzzleInput path: ");
			var path = Console.ReadLine();

			var SectionAssignments = File.ReadAllLines(path);

			var OverlappingAssignments = 0;
			var Total = 0;



			foreach (var line in SectionAssignments)
			{
				var indexComma = line.IndexOf(",");

				var firstSection = line.Substring(0, indexComma);
				var secondSection = line.Substring(indexComma + 1);


				var startOne = Convert.ToInt32(firstSection.Split('-')[0]);
				var endOne = Convert.ToInt32(firstSection.Split('-')[1]);
				var startTwo = Convert.ToInt32(secondSection.Split('-')[0]);
				var endTwo = Convert.ToInt32(secondSection.Split('-')[1]);





				// Part One Solution
				if (startTwo >= startOne && endTwo <= endOne)
				{
					OverlappingAssignments++;
				}
				else if (startOne >= startTwo && endOne <= endTwo)
				{
					OverlappingAssignments++;
				}

				// Part Two Solution
				if (endOne >= startTwo && endTwo >= startOne)
				{
					Total++;
				}


				
			

				
				
            }



			return Total;
		}
	}
}

