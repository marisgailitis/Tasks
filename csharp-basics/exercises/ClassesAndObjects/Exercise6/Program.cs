using System.Linq;
using System.Net.Mail;

namespace Excercise6
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<Dog> dogs = new List<Dog>();

			Dog max = new Dog("Max", Dog.Gender.Male);
			Dog rocky = new Dog("Rocky", Dog.Gender.Male);
			Dog sparky = new Dog("Sparky", Dog.Gender.Male);
			Dog buster = new Dog("Buster", Dog.Gender.Male);
			Dog sam = new Dog("Sam", Dog.Gender.Male);
			Dog lady = new Dog("Lady", Dog.Gender.Female);
			Dog molly = new Dog("Molly", Dog.Gender.Female);
			Dog coco = new Dog("Coco", Dog.Gender.Female);

			dogs.Add(max);
			dogs.Add(rocky);
			dogs.Add(sparky);
			dogs.Add(buster);
			dogs.Add(sam);
			dogs.Add(lady);
			dogs.Add(molly);
			dogs.Add(coco);

			max.SetParents(lady, rocky);
			coco.SetParents(molly, buster);
			rocky.SetParents(molly, sam);
			buster.SetParents(lady, sparky);

			Console.WriteLine(coco.GetFathersName());
			Console.WriteLine(sparky.GetFathersName());

			Console.WriteLine(coco.HasSameMotherAs(rocky));
		}
    }
}