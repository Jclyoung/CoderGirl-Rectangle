using System;

namespace Rectangle
{
    public static class Program
    {
        public static void Main()
        {
            int length = 0;
            int width = 0;
            Console.Write("Enter the length of the rectangle: ");
            // Get input from the user and save it to a variable.
            string lengthInput = Console.ReadLine();
            int.TryParse(lengthInput, out length);
                     

            Console.Write("Enter the width of the rectangle: ");
            string widthInput = Console.ReadLine();
            widthInput = widthInput.Trim();
            int.TryParse(widthInput, out width);

            int rectangleArea = (length * width);
            Console.WriteLine($"The total area of the rectangle is {rectangleArea}");

            // Get input from the user and save it to a second variable.
            Console.ReadLine();

            // Output - The area of the rectangle is (computed value)

           
        }
    }
}
