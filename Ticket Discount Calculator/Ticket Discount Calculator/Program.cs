internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Price of the Ticket is Gh10");
        Console.WriteLine("Discount allowed is Gh7");
        Console.WriteLine("Enter age to determine whether you qualify for discount ");
        int age = Convert.ToInt32(Console.ReadLine());
        int price = 10;
        int discout = 7;

        if (age >= 65 || age <= 12)
        {
            Console.Write("Your discounted price is Gh" + (price - discout));
        }
        else
        {
            Console.WriteLine("You do not qualify for a discount");
        }










        


    }

}