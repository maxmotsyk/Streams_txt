using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApplication1.FolderPersonalities;

namespace ConsoleApplication1
{
    public class functionull
    {
        protected string PathTxt { get; set; }
        protected List<Tailor> tailorList = new List<Tailor>();
        protected List<Singer> singerList = new List<Singer>();
        public functionull()
        {
            this.PathTxt = "BD.txt";
        }
        protected void AddInTxt()
        {
            using (var sw = new StreamWriter(PathTxt,true))
            {

            }
        }

        protected string ReadeTxt()
        {
            using (var sr = new StreamReader(PathTxt))
            {
                while (!sr.EndOfStream)
                {
                    SortObj(sr.ReadLine())
                }
            }
            return "fd";
        }

        protected int Parse()
        {
            return 0;
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
                    tailorList.Add(new Tailor(massData[1], massData[2],int.Parse(massData[3]), massData[4],double.Parse(massData[5]), massData[6], massData[7]));
                }
                else
                {
                    singerList.Add(new Singer(massData[1], massData[2], int.Parse(massData[3]), massData[4], double.Parse(massData[5]), massData[6], massData[7]));
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
        }
    }
}