using System.Drawing;
using System.Linq;
using System.Net.Mail;

namespace Excercise8
{
    public class Program
    {
        static void Main(string[] args)
        {
			Point p1 = new Point(5, 2);
			Point p2 = new Point(-3, 6);

			SwapPoints(ref p1, ref p2);

			Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
			Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
		}

		private static void SwapPoints(ref Point p1, ref Point p2)
		{
			Point firstPoint = p1;
			p1 = p2;
			p2 = firstPoint;
		}
    }
}