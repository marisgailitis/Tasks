namespace Subjects
{
	class SubjectData
	{
		public string Subject => subject;
		public string Prefix => prefix;
		public string TeacherSurname => teacherSurname;

		private string subject;
		private string prefix;
		private string teacherSurname;

		public SubjectData(string subject_, TeacherPrefixType prefixType, string teacherSurname_)
		{
			subject = string.Copy(subject_);

			switch(prefixType) 
			{
				case TeacherPrefixType.mister:
				{
					prefix = "Mr.";
					break;
				}
				case TeacherPrefixType.misses:
				{
					prefix = "Mrs.";
					break;
				}
				case TeacherPrefixType.miss:
				{
					prefix = "Miss.";
					break;
				}
				default:
					prefix = "Ms.";
					break;
			}

			teacherSurname = string.Copy(teacherSurname_);
		}

		public enum TeacherPrefixType
		{
			mister,
			misses,
			miss,
			mizz
		}
	}
}