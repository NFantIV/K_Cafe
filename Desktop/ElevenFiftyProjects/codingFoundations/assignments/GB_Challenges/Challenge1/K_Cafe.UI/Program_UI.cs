using static System.Console;
public class Program_UI
{
    private readonly MenuItemRepository _mRepo = new MenuItemRepository();
        public void Run()
        {
            SeedContent();
            RunApplication();
        }

    public void RunApplication()
    {
        bool isRunning = true;
        while (isRunning)
        {
            WriteLine ("Welcome to Komodo Café\n" +
            "1. Add Menu Item to database\n" +
            "2. View All Menu Items\n" +
            "3. Delete Menu Item Data\n" +
            "0. Exit App\n");
            string userInput = ReadLine();

            switch (userInput)
            {
                case "1":
                AddMenuItem();
                break;
                case "2":
                ShowMenuItem();
                break;
                Clear();
                _mRepo.PrintMenu();
                break;
                case "3":
                DeleteMenuItem();
                break;
                case "0":
                isRunning = false;
                break;
        }
    }
}

public void ShowMenuItem()
{
    List<MenuItem> menuItems = _mRepo.GetMenuItems();

    foreach (MenuItem item in menuItems)
    {
        string IngredientList = string.Join(", ", item.MealIngredients);
        WriteLine($"Meal Name: {item.MealName}");
        WriteLine($"Meal Description: {item.MealDescription}");
        WriteLine($"Meal Number: {item.MealNumber}");
        WriteLine($"Meal Ingredients:{item.MealIngredients}");
        WriteLine($"Meal Price: {item.MealPrice}");
    }
}
    public void AddMenuItem()
    {
        MenuItem newMenuItem = new MenuItem();

        WriteLine($"Enter meal number of {newMenuItem}");
        newMenuItem.MealNumber = int.Parse(ReadLine());

        WriteLine ("Name of item");
        newMenuItem.MealName = ReadLine();

        WriteLine("Description of Item");
        newMenuItem.MealDescription = ReadLine();

        WriteLine($"Ingredients: {newMenuItem.MealName}");
        string IngredientList = ReadLine();

        WriteLine($"Enter price of {newMenuItem.MealName}");
        newMenuItem.MealPrice = decimal.Parse(ReadLine());
        
        _mRepo.AddItemToMenu(newMenuItem);
        WriteLine($"{newMenuItem.MealName} added");
    }

    private void DeleteMenuItem()
    {
        Clear();
        WriteLine("Please type the Menu Item's Number: ");
        while (true)
        {
            string input = ReadLine();
            bool wasParsed = int.TryParse(input, out int intNum);
            if (wasParsed)
            {
                bool isRemoved = _mRepo.DeleteMenuItem(intNum);
                if (isRemoved)
                {
                    Console.WriteLine("Item Removed from Menu.");
                    return;
                }
            else Console.Write("Invalid. Please Enter a Number: ");
            }
        }
    }
    public void SeedContent()
    {
        MenuItem taco = new MenuItem(1, "Taco", "Hardshell mexican cusine", new List<string>(), 5);
        taco.AddIngredient("Beef");
        taco.AddIngredient("tomatoes");
        taco.AddIngredient("Lettuce");
        
        MenuItem salad = new MenuItem(2, "salad", "a mix of healthy veggies in one bowl", new List<string>(), 8);
        salad.AddIngredient("Croutons");
        salad.AddIngredient("tomatoes");
        salad.AddIngredient("Lettuce");
        salad.AddIngredient("Cheese");

        _mRepo.AddItemToMenu(taco);
        _mRepo.AddItemToMenu(salad);
    }
}
