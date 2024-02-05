namespace Exercise13
{
	class Ingredient
	{
		public string Name { get; set; }
		public double Cost { get; set; }

		public Ingredient(string name, double cost)
		{
			Name = name;
			Cost = cost;
		}
	}
}