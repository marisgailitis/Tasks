using System;
using System.Runtime.CompilerServices;

namespace Exercise10
{
    public class Video
    {
        public string Title { get; private set; }
		public bool CheckedOut { get; private set; }
		public Video(string Title_)
		{
			Title = Title_;
		}

		public void GetCheckedOut()
		{
			ChangeStatus(true);
		}

		public void GetReturned()
		{
			ChangeStatus(false);
		}

		public void ChangeStatus(bool state)
		{
			CheckedOut = state;
		}
    }
}