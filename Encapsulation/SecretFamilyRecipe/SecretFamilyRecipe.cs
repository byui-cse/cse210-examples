public class SecretFamilyRecipe
{
    private string _name;
    private List<string> _ingredients = new List<string>();
    private List<string> _directions = new List<string>();

    private string _password;

    public SecretFamilyRecipe(string password, string recipeName, List<string> ingredients, List<string> directions)
    {
        _password = password;
        _name = recipeName;
        _ingredients = ingredients;
        _directions = directions;
    }

    public SecretFamilyRecipe(string password)
    {
        _name = "PB&J";

        _password = password;

        _ingredients.Add("Bread");
        _ingredients.Add("Peanut Butter");
        _ingredients.Add("Jam");
        _ingredients.Add("Salt");

        _directions.Add("Lay out bread");
        _directions.Add("Spread PB on first slice");
        _directions.Add("Spread Jam on second slice");
        _directions.Add("Sprinkle salt on both");
        _directions.Add("Put sides together");
    }

    public SecretFamilyRecipe() : this("GrandmaLovesBroccoli") 
    {
    }

    public void SetPassword(string oldPassword, string newPassword)
    {
        if (oldPassword == _password && newPassword.Length > 0)
        {
            _password = newPassword;
        }
    }
    public void Display(string password)
    {
        if (password == _password)
        {
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in _ingredients)
            {
                Console.WriteLine(ingredient);
            }


            Console.WriteLine("\nDirections:");
            foreach (string direction in _directions)
            {
                Console.WriteLine(direction);
            }            
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }

    }
}





















// using System.ComponentModel;

// public class SecretFamilyRecipe
// {
//     private string _password = "GrandmaDespisesBroccoli";

//     // This secret family recipe is actually a statistically generated recipe from ChatGPT
//     private string _recipe;

//     public SecretFamilyRecipe(string recipe)
//     {
//         if (recipe.Length > 5)
//         {
//             _recipe = recipe;
//         }
//         else
//         {
//             throw new Exception("The Recipe was too short!");
//         }
//     }

//     public SecretFamilyRecipe(string recipe, string password) : this(recipe)
//     {
//         _password = password;
//     }

//     public void SetPassword(string newPassword, string oldPassword)
//     {
//         if (_password == oldPassword)
//             _password = newPassword;
//     }

//     public string GetRecipe()
//     {
//         return _recipe;
//     }

//     public string Reveal(string password)
//     {
//         if (password == _password)
//             return _recipe;
//         else
//         {
//             return "Access Denied!";
//         }
//     }
// }
