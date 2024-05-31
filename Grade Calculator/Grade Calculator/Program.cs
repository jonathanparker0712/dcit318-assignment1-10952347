internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter marks to determine grade ");
        int marks = Convert.ToInt32(Console.ReadLine());


        if (marks >= 90)
        {
            Console.WriteLine("A");
        }
        else if (marks >= 80)
        {
            Console.WriteLine("B");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("C");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("D");

        }
        else
        {
            Console.WriteLine("F");
        }






        


    }

}