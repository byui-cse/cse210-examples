public class PlotManager
{
    public string _fileName = "sodfarm.txt";
    public List<Plot> _plots = new List<Plot>();

    /// <summary>
    /// Run the program, collecting dimensions for 
    /// </summary>
    public void Run()
    {
        do
        {
            Console.Write("Add a plot? (y/n) ");
            if (Console.ReadLine().ToLower() == "n")
                break;

            try
            {
                Console.Write("Enter Length (ft): ");
                double l = double.Parse(Console.ReadLine());
                Console.Write("Enter Width (ft): ");
                double w = double.Parse(Console.ReadLine());

                Plot p = new Plot();
                p._length = l;
                p._width = w;
                _plots.Add(p);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }                
        } while (true);

        // Display Plot list
        DisplayPlots();

        // Display total area
        Console.WriteLine($"Total Area is: {CalculateTotalArea()} ft^2");

        // Save the plots to disk
        SavePlots();
    }


    /// <summary>
    /// Iterate through the plots and calculate the total area
    /// </summary>
    /// <returns></returns>
    public double CalculateTotalArea()
    {
        double totalArea = 0;
        foreach (Plot p in _plots)
        {
            totalArea =+ p.GetArea();
        }            
        return totalArea;
    }

    /// <summary>
    /// Displays all plots, including dimensions and area
    /// </summary>
    public void DisplayPlots()
    {
        if (_plots.Count == 0)
        {
            Console.WriteLine("No plots found.");
            return;
        }

        foreach (Plot p in _plots)
        {
            Console.WriteLine(p.ToString());
        }
    }

    /// <summary>
    /// Writes all plots to a file, one plot per line
    /// Note: _filename is the output file path
    /// </summary>
    public void SavePlots()
    {
        // Save the plots to file (one plot per line)
    }
}
