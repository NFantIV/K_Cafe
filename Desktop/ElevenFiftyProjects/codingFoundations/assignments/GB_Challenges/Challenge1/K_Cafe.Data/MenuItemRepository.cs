public class MenuItemRepository
    {
        private readonly List<MenuItem>
        _MenuItemDB = new List<MenuItem>();
        private int _count;

// Create
public void AddItemToMenu(MenuItem MenuItem)
{
    _MenuItemDB.Add(MenuItem);
}

// Read
public List<MenuItem>
GetMenuItems()
{
    return _MenuItemDB;
}

public MenuItem GetMenuItem(int mealNumberItem)
{
    foreach (MenuItem menuItem in _MenuItemDB)
    {
        if (menuItem.MealNumber == mealNumberItem)
        {
            return menuItem;
        }
    }
    return null;
}
public void PrintMenu()
    {
        foreach (MenuItem item in _MenuItemDB)
        {
            System.Console.WriteLine(
                $"Meal Number: {item.MealNumber}\n" +
                $"Meal Name: {item.MealName}\n" +
                $"Meal Description: {item.MealDescription}\n" +
                $"{item.MealIngredients}\n" +
                $"Meal Price: {item.MealPrice}\n" 
            );
        }
    }    
// Delete
public bool DeleteMenuItem(int mealNumberItem)
    {
        MenuItem mealItemInDb = GetMenuItem(mealNumberItem);
        if (mealItemInDb != null)
        {
            _MenuItemDB.Remove
            (mealItemInDb);
            return true;
        }
            return false;
    }
}