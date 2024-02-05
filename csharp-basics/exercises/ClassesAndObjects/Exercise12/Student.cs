using System.Linq;
using System.Text;

namespace Exercise12
{
	public class Student : IStudent
	{
		public string[] TestsTaken { get; set; }

		public Student()
		{
			TestsTaken = new string[0];
		}

		public string TestResults()
		{
			if (TestsTaken == null)
			{
				return new string("No tests taken");
			}
			StringBuilder builder = new StringBuilder();

			foreach (string test in TestsTaken)
			{
				builder.Append($"{test}, ");
			}
			return builder.ToString();
		}

		public void TakeTest(ITestPaper paper, string[] answers)
		{
			double markPerCorrectAnswer = 100 / (double)answers.Length;
			double receivedMark = 0;

			for (int i = 0; i < answers.Length; i++)
			{
				if (answers[i].Equals(paper.MarkScheme[i]))
					receivedMark += markPerCorrectAnswer;
			}
			GetGrade(paper, receivedMark);
		}

		private void GetGrade(ITestPaper paper, double receivedMark)
		{
			string passedString = receivedMark >= StringToNumber(paper.PassMark) ? "Passed!" : "Failed!";
			string percentString = $"{Math.Round(receivedMark)}%";

			List<string> tests = TestsTaken.ToList();
			tests.Add($"{paper.Subject}: {passedString} ({percentString})");
			TestsTaken = tests.ToArray();
		}

		private double StringToNumber(string s)
		{
			string percentString = s.TrimEnd('%');
			double percentage = double.Parse(percentString);

			return percentage;
		}
	}
}