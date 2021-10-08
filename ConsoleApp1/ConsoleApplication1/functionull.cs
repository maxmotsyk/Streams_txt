using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApplication1.FolderPersonalities;

namespace ConsoleApplication1
{
    public class functionull
    {
        protected string PathTxt { get; set; }
        protected List<Singer> SingerList = new List<Singer>();
        protected List<Tailor> TailorList = new List<Tailor>();

        public functionull()
        {
            this.PathTxt = "BD.txt";
        }
        public void AddInTxt(string temp)
        {
            try
            {
                if(temp == "")
                {
                    throw new Exception("ERROR:object empty");
                }
                using (var sw = new StreamWriter(PathTxt, true))
                {
                    sw.WriteLine(temp);
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void ReadeTxt()
        {
            using (var sr = new StreamReader(PathTxt))
            {
                while (!sr.EndOfStream)
                {
                    SortObj(sr.ReadLine());
                }
            }
        }

        public List<object> Parse()
        {
            List<object> tempList = new List<object>();
            foreach(Singer persone in SingerList)
            {
                if (persone.Сourse == 1 && persone.AverageScore >= 10 && persone.Country != "Ukraine")
                {
                    tempList.Add(persone);
                }
            }

            foreach (Tailor persone in TailorList)
            {
                if (persone.Сourse == 1 && persone.AverageScore >= 10 && persone.Country != "Ukraine")
                {
                    tempList.Add(persone);
                }
            }

            return tempList;
        }

        protected void SortObj(string dataStr)
        {
            try
            {
                if (dataStr == "")
                {
                    throw new Exception("ERROR:empty line");
                }
                string[] massData = dataStr.Split(' ');

                if(massData[0] == "Tailor")
                {
                    TailorList.Add(new Tailor(massData[1], massData[2],int.Parse(massData[3]), massData[4],double.Parse(massData[5]), massData[6], massData[7]));
                }
                else
                {
                    SingerList.Add(new Singer(massData[1], massData[2], int.Parse(massData[3]), massData[4], double.Parse(massData[5]), massData[6], massData[7]));
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}