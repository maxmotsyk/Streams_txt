using System;

namespace ConsoleApplication1
{
    public class console : functionull
    {
        protected functionull fun { get; set; }
        
        public console()
        {
            fun = new functionull();
        }

        public void Menu()
        {
            //string pathDB = "DB.txt";
            int choise = 0;
            bool trueFalse = true;
            while (trueFalse)
            {
                Console.WriteLine("1-Reading from file\n2-Write to file\n3-Number of foreign students\n0-Exit\n");
                choise = int.Parse(Console.ReadLine());
                switch(choise)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 0:
                        trueFalse = false;
                        break;
                    default:
                        Console.WriteLine("1-Reading from file\n2-Write to file\n3-Number of foreign students\n0-Exit\n");
                        choise = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}