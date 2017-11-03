using System;

namespace TreehouseDefense
{
    class Game
    {
        static void Main()
        {
            // convention is to name classes with upper case first letter, so you can name the object by their type (class) 
            //object is an instance of a class
            Tower tower = new Tower();

            Map map = new Map(4,4);
            // map.Width = 8;  //can not do, due to readonly access

            Console.WriteLine(map.Width);
            Console.ReadLine();
        }
    }
}
