using System;
using System.Collections.Generic;
using System.Text;
using Subjects;

class Program
{
	private List<SubjectData> subjects = new List<SubjectData>();
	private Symbols symbols = new Symbols();
	private Lengths lengths = new Lengths();
	private static Program singleton;

	static void Main(string[] args)
	{
		if(singleton == null) singleton = new Program();

		singleton.FillSubjects();
		singleton.GetLongestStrings();

		Console.WriteLine(singleton.DrawBorder());
		for(int i = 0; i < singleton.subjects.Count; i++)
		{
			Console.WriteLine(singleton.DrawContentLine(i));
		}
		Console.WriteLine(singleton.DrawBorder());
	}

	private string DrawContentLine(int index)
	{
		StringBuilder sb = new StringBuilder();
		
		sb.Append(symbols.leftEnd);
		sb.Append(index.ToString());
		sb.Append(symbols.middle);

		singleton.AppendEmptySpace(ref sb, lengths.longestSubjectNameLength - subjects[index].Subject.Length);

		sb.Append(subjects[index].Subject);
		sb.Append(symbols.middle);

		singleton.AppendEmptySpace(ref sb, lengths.longestPrefixLength - subjects[index].Prefix.Length);
		singleton.AppendEmptySpace(ref sb, lengths.longestNameLength - subjects[index].TeacherSurname.Length);

		sb.Append(subjects[index].Prefix);
		sb.Append(" ");
		sb.Append(subjects[index].TeacherSurname);
		sb.Append(symbols.rightEnd);

		return sb.ToString();
	}
	private void AppendEmptySpace(ref StringBuilder sb, int length)
	{
		for(int i = 0; i < length; i++)
		{
			sb.Append(" ");
		}
	}

	private string DrawBorder()
	{
		StringBuilder sb = new StringBuilder();
		
		sb.Append(symbols.cornerSymbol);

		int length = GetBorderLineLength();

		for(int i = 0; i < length; i++)
		{
			sb.Append(symbols.borderSymbol);
		}

		sb.Append(symbols.cornerSymbol);

		return sb.ToString();
	}

	private int GetBorderLineLength()
	{
		int length = symbols.leftEnd.Length;
		length += symbols.middle.Length;
		length += lengths.longestSubjectNameLength;
		length += symbols.middle.Length;
		length += lengths.longestPrefixLength;
		length += lengths.longestNameLength;
		length += symbols.rightEnd.Length;

		return length;
	}

	private void GetLongestStrings()
	{
		for(int i = 0; i < subjects.Count; i++)
		{
			SubjectData data = subjects[i];

			if(data.Subject.Length > lengths.longestSubjectNameLength)
			{
				lengths.longestSubjectNameLength = data.Subject.Length;
			}
			if(data.Prefix.Length > lengths.longestPrefixLength)
			{
				lengths.longestPrefixLength = data.Prefix.Length;
			}
			if(data.TeacherSurname.Length > lengths.longestNameLength)
			{
				lengths.longestNameLength = data.TeacherSurname.Length;
			}
		}
	}

	private void FillSubjects()
	{
		subjects.Add(new SubjectData("English III", SubjectData.TeacherPrefixType.mizz, "Lapan"));
		subjects.Add(new SubjectData("Precalculus", SubjectData.TeacherPrefixType.misses, "Gideon"));
		subjects.Add(new SubjectData("Music Theory", SubjectData.TeacherPrefixType.mister, "Davis"));
		subjects.Add(new SubjectData("Biotechnology", SubjectData.TeacherPrefixType.mizz, "Palmer"));
		subjects.Add(new SubjectData("Principles of Technology I", SubjectData.TeacherPrefixType.mizz, "Garcia"));
		subjects.Add(new SubjectData("Latin II", SubjectData.TeacherPrefixType.misses, "Barnett"));
		subjects.Add(new SubjectData("AP US History", SubjectData.TeacherPrefixType.mizz, "Johannessen"));
		subjects.Add(new SubjectData("Business Computer Infomation Systems", SubjectData.TeacherPrefixType.mister, "James"));
	}

	private class Lengths
	{
		public int longestSubjectNameLength = 0;
		public int longestPrefixLength = 0;
		public int longestNameLength = 0;
		public int lineSymbolCount = 0;
	}

	private class Symbols()
	{
		public string leftEnd = "| ";
		public string middle = " | ";
		public string rightEnd = " |";
		public string borderSymbol = "-";
		public string cornerSymbol = "+";
	}
}
