using System;
using System.Collections.Generic;

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
            int choise = 0;
            bool trueFalse = true;
            while (trueFalse)
            {
                Console.WriteLine("1-Reading from file\n2-Write to file\n3-Number of foreign students\n0-Exit\n");
                choise = int.Parse(Console.ReadLine());
                switch(choise)
                {
                    case 1:
                        fun.ReadeTxt();
                        break;
                    case 2:
                        fun.AddInTxt(CreateObj());
                        break;
                    case 3:
                        Open(fun.Parse());
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

        protected string CreateObj()
        {
            string name, lastname, sex, country, idpasport,persone;
            double averagescore;
            int course;
            Console.WriteLine("Enter persone-");
            persone = Console.ReadLine();

            Console.WriteLine("Enter name-");
            name = Console.ReadLine();
            Console.WriteLine("Enter lastname-");
            lastname = Console.ReadLine();

            Console.WriteLine("Enter sex-");
            sex = Console.ReadLine();

            Console.WriteLine("Enter country-");
            country = Console.ReadLine();

            Console.WriteLine("Enter id pasport-");
            idpasport = Console.ReadLine();

            Console.WriteLine("Enter average score-");
            averagescore = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter course-");
            course = int.Parse(Console.ReadLine());

            return $"{persone} {name} {lastname} {course} {sex} {averagescore} {country} {idpasport}";
        }

        protected void Open(List<object> templist)
        {
            Console.WriteLine(templist.Count);

            foreach(object persone in templist)
            {
                Console.WriteLine(persone);
            }
        }
    }
}