using System;

namespace MethodOverloading
{
    class Program
    {
        public static string Add(int x, int y, bool myBool)
        {
            if (myBool == true)
            {
                if (x + y == 1)
                {
                    return "1 dollar";
                }else
                {
                    return $"{x + y} dollars";
                }
            } else
            {
                return null;
            }
        }


        public static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 5));
            Console.WriteLine(Add(4, 5, true));
        }
    }
}
