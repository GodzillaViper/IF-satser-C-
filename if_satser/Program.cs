internal class Program
{
    private static void Main(string[] args)
    {
        //upgift1
        //Console.WriteLine ("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter second number:");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //if (num > num2)
        //{
       //     Console.WriteLine($"{num} is greater than {num2}");
       // }
       // else
        //{
        //    Console.WriteLine($"{num2} is greater than {num}");
        //}

        //uppgift2
        //int number; 
        //Console.WriteLine("Enter a number between 1-100: ");
        //number = Convert.ToInt32(Console.ReadLine());
        //if (number >= 0 && number <= 12) {
            //Console.WriteLine("White");
        //}
        //if (number >= 13 && number <= 24) {
            //Console.WriteLine("green");
        //}
        //if (number >= 25 && number <= 36) {
            //Console.WriteLine("red");
        //}
        //if (number >= 37 && number <= 99) {
            //Console.WriteLine("blue");
        //}

        //uppgift3
        //Console.WriteLine ("Enter a number: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //if (num % 2 == 0)
        //{
            //Console.WriteLine("Number is even");
        //}
        //else
        //{
            //Console.WriteLine("Number is odd");
        //}

        //uppgift4
        Console.WriteLine("Enter a character: ");
        string character = Console.ReadLine();

        switch(character) {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                Console.WriteLine("Character is a Vowel");
                break;
            default:
                Console.WriteLine("Character is a Consonant");
                break;
        }
    }
        
}
