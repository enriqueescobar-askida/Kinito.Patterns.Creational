using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E4SS.DesignPattern.Creat.Prototype_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();
            // Initialize with standard colors
            colormanager["red"] = new ConcreteColor(255, 0, 0);
            colormanager["green"] = new ConcreteColor(0, 255, 0);
            colormanager["blue"] = new ConcreteColor(0, 0, 255);
            // User adds personalized colors
            colormanager["angry"] = new ConcreteColor(255, 54, 0);
            colormanager["peace"] = new ConcreteColor(128, 211, 128);
            colormanager["flame"] = new ConcreteColor(211, 34, 20);
            // User clones selected colors
            ConcreteColor color1 = colormanager["red"].Clone() as ConcreteColor;
            ConcreteColor color2 = colormanager["peace"].Clone() as ConcreteColor;
            ConcreteColor color3 = colormanager["flame"].Clone() as ConcreteColor;
            // Wait for user
            Console.ReadKey();
        }
    }
}