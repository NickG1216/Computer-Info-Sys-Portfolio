//B7263
//Program 1
//CIS 199-75
//September 26, 2017
//This is an interactive console program that calculates the amount of paint needed to cover a specific room and how many gallons to buy.   


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            const int CAN_OF_PAINT = 350;// One can of paint covers 350 square feet.
            const int LENGTH_OF_DOORS = 20;//Subtract 20 feet from the perimeter for each door.
            const int LENGTH_OF_WINDOWS = 15;// Subtract 15 feet from the perimeter for each window.
            
            int coatsOfPaint;// The variable for the desired amount of coats of paint.
            int numOfDoors;// The variable for the number of doors in the room.
            int numOfWindows;// The variable for the number of windows in the room.
            double mingallons;// The minimum amount of gallons of paint needed to paint the room. 
            double gallonsToBuy;// How many galons you should buy to paint the room. 
            double perimeter;// The total length of all walls in the room.
            double height;// The height of all walls in the room you want to paint.
            double sqFtToPaint;// Total square feet to be painted per coat.
           
            Console.WriteLine("Welcome to the I'm Required to do This For a Grade Paint Estimator\n"); 
            Console.Write("Enter the perimeter of all walls (in feet): ");
            perimeter = double.Parse(Console.ReadLine());
            Console.Write("Enter the height of all walls (in feet): ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Enter the number of doors (posivtive num): ");
            numOfDoors = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of windows (positive num): ");
           numOfWindows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of coats of paint (positive num): ");
            coatsOfPaint = int.Parse(Console.ReadLine());
            sqFtToPaint = ((perimeter * height) - (LENGTH_OF_DOORS * numOfDoors) - (LENGTH_OF_WINDOWS * numOfWindows)) * coatsOfPaint;
            mingallons = sqFtToPaint / CAN_OF_PAINT;
            gallonsToBuy = (int)Math.Ceiling(mingallons);
            Console.WriteLine($"\nYou will need a minimum of {mingallons:F1} gallons of paint");
            Console.WriteLine($"You'll need to buy {gallonsToBuy} gallons, though");
           
            
            


        }
    }
}
