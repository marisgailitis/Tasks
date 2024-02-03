namespace Exercise12
{
    public interface IStudent
	{
		public string[] TestsTaken { get; set; }
		public void TakeTest(ITestPaper paper, string[] answers);
	}
}