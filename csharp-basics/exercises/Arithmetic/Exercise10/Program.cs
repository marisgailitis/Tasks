using System;

class Program
    {
        static void Main(string[] args)
        {
			List<Action> actions = new List<Action>();
			AddActions(ref actions);

            int choice = GetMenu();
			Action chosenCalculation = actions[choice - 1];
			chosenCalculation.Invoke();
        }

		private static void AddActions(ref List<Action> actions)
		{
			Action calculateCircle = () => CalculateCircleArea();
			Action calculateRectangle = () => CalculateRectangleArea();
			Action calculateTriangle = () => CalculateTriangleArea();
			Action quit = () => Environment.Exit(0);
			actions.Add(calculateCircle);
			actions.Add(calculateRectangle);
			actions.Add(calculateTriangle);
			actions.Add(quit);
		}

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

			GetChoiceInput:
            var input = Console.ReadLine();

			int userChoice = 0;
			if(int.TryParse(input, out userChoice))
			{
				if(userChoice < 1 || userChoice > 4)
				{
					Console.WriteLine("The number must be higher than 0 and lower than 5");
					goto GetChoiceInput;
				}
			}
			else
			{
				Console.WriteLine("Enter a number 1 - 4");
				goto GetChoiceInput;
			}

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");

			GetCircleRadius:
			var input = Console.ReadLine();
			double radius = 0;

			if(double.TryParse(input, out radius))
			{
				if(radius < 0)
				{
					Console.WriteLine("Radius cannot be negative");
					goto GetCircleRadius;
				}
			}
			else
			{
				Console.WriteLine("Enter a positive number");
				goto GetCircleRadius;
			}

			double area = double.Round(3.14 * radius * radius, 2);
            
            Console.WriteLine($"The circle's area is {area}");
        }

        public static void CalculateRectangleArea()
        {
            double length = 0;
            double width = 0;

            Console.WriteLine("Enter length? ");

            GetRectangleLength:
			var input = Console.ReadLine();

			if(double.TryParse(input, out length))
			{
				if(length < 0)
				{
					Console.WriteLine("Length cannot be negative");
					goto GetRectangleLength;
				}
			}
			else
			{
				Console.WriteLine("Enter a positive number");
				goto GetRectangleLength;
			}

            Console.WriteLine("Enter width? ");

			GetRectangleWidth:
			input = Console.ReadLine();

			if(double.TryParse(input, out width))
			{
				if(width < 0)
				{
					Console.WriteLine("Width cannot be negative");
					goto GetRectangleWidth;
				}
			}
			else
			{
				Console.WriteLine("Enter a positive number");
				goto GetRectangleWidth;
			}

			double area = double.Round(length * width, 2);

            Console.WriteLine($"The rectangle's area is {area}");
        }

        public static void CalculateTriangleArea()
        {
            double ground = 0;
            double height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");

            GetRectangleLength:
			var input = Console.ReadLine();

			if(double.TryParse(input, out ground))
			{
				if(ground < 0)
				{
					Console.WriteLine("Length cannot be negative");
					goto GetRectangleLength;
				}
			}
			else
			{
				Console.WriteLine("Enter a positive number");
				goto GetRectangleLength;
			}

            Console.WriteLine("Enter triangle's height? ");

			GetTriangleHeight:
			input = Console.ReadLine();

			if(double.TryParse(input, out height))
			{
				if(height < 0)
				{
					Console.WriteLine("Height cannot be negative");
					goto GetTriangleHeight;
				}
			}
			else
			{
				Console.WriteLine("Enter a positive number");
				goto GetTriangleHeight;
			}

			double area = double.Round(ground * height / 2);

            Console.WriteLine($"The triangle's area is {area}");
        }
    }