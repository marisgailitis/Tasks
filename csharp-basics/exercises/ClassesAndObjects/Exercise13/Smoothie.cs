using System.Text;

namespace Exercise13
{
    class Smoothie
    {
        public Ingredient[] Ingredients { get; set; }

		public double GetCost()
		{
			double cost = 0;

			foreach(Ingredient ingredient in Ingredients)
				cost += ingredient.Cost;
				
			return cost;
		}
		public double GetPrice()
		{
			double cost = GetCost();
			return cost + cost * 1.5;
		}
		public string GetName()
		{
			string endName = Ingredients.Length > 0? "Fusion" : "Smoothie";

			StringBuilder builder = new StringBuilder();

			foreach(Ingredient ingredient in Ingredients)
			{
				builder.Append($"{ingredient.Name} ");
			}
			builder.Replace("berries", "berry");
			builder.Append(endName);

			return builder.ToString();
		}
    }
}