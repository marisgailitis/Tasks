using System.Linq;
using System.Net.Mail;

namespace Excercise6
{
    public static class DogExtensions
	{
		public static void SetParents(this Dog dog, Dog mother, Dog father)
		{
			if(mother.Sex == father.Sex)
			{
				throw new ArgumentException("you can't be born to two same sex parents even though it is century 21");
			}

			dog.Mother = mother;
			dog.Father = father;
		}
		public static bool HasSameMotherAs(this Dog dog, Dog otherDog)
		{
			return dog.Mother != null && otherDog.Mother.Name == dog.Mother.Name;
		}

		public static string GetFathersName(this Dog dog)
		{
			return dog.Father != null ? dog.Father.Name : "Unknown";
		}
	}
}