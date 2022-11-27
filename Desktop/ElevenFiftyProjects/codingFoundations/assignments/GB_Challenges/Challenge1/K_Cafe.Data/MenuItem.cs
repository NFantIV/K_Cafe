public class MenuItem
    {
        public MenuItem(int mealNumber, string mealName, string mealDescription, List<string> mealIngredients, int mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }

    public List<string> MealIngredients { get; set; }
        public decimal MealPrice { get; set; }

        public void AddIngredient(string mealIngredients)
        {
            MealIngredients.Add(mealIngredients);
        }
        private string IngredientList(List<string> mealIngredients)
        {
            string mealList = "Ingredients:" + String.Join(", ", mealIngredients);
            return mealList;
        }
        public MenuItem() { }
    }
