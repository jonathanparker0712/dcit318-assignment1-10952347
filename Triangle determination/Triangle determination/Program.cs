internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the first side");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the second side ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the length of the third  side ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // for a triangle to be equilateral all sides should be equal 
        // for a triangle to be isoceles two side should be equal 
        // for a triangle to be scalene all sides should be differrent in length

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("This is an equilateral triangle");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("This is an isoceles triangle");
        }
        else
        {
            Console.WriteLine("The triangle is scalene");
        }
















        Console.ReadLine();


    }

}