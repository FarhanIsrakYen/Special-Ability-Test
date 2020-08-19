using System;

namespace windmill
{
    class Program
    {
        
        public static void Main(string[] args)
        {

            int wheelMillsNum = 3;

            int asteriskInEach = 4;
            
            for(int i = 0; i < wheelMillsNum; i++)
            {
                Asterisk(asteriskInEach);
            }
            


        }

        // this method is used to create the windmill sequence as Sensei mentioned in question
        static void Asterisk(int num)
        {
            //this for loop creates upper two wheels
            for (int i = 0; i < num; ++i)
            {
                stars(i + 1); 

                spaces(num - i - 1);

                stars(num - i);

                spaces(2 * i);

                Console.WriteLine();
            }

            //this for loop creates lower wheels
            for (int i = 0; i < num; ++i)
            {

                spaces(num - i - 1);

                stars(i + 1);

                spaces(i);

                stars(num - i);

                Console.WriteLine();
            }

            // this method is used to create asterisks only
            static void stars(int stars)
            {
                for (int i = 0; i < stars; ++i)
                    Console.Write("*");
            }

            // this method is used to create spaces only
            static void spaces(int spaces)
            {
                for (int i = 0; i < spaces; ++i)
                    Console.Write(" ");
            }
        }
    }
}
