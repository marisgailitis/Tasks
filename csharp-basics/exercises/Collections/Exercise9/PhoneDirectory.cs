using System;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _data;
        private int _dataCount;

        public PhoneDirectory() 
		{
            _data = new SortedDictionary<string, string>();
            _dataCount = 0;
        }

		public bool Find(string name)
		{
			return _data.ContainsKey(name);
		}

        public string GetNumber(string name) 
        {
            if(Find(name))
				return _data[name];
            else 
				return null;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }

            if(Find(name))
			{
				// existing number, replace
				_data[name] = number;
			}
            else 
            {
				// new number, add to the directory
                _data.Add(name, number);
            }
        }
    }
}