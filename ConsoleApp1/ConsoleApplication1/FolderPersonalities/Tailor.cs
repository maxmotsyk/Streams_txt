namespace ConsoleApplication1.FolderPersonalities
{
    public class Tailor : Ipersonaliti
    {
        public Tailor(string name ,string lastName,int cours,string sex,double score,string country,string id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Сourse = cours;
            this.Sex = sex;
            this.AverageScore = score;
            this.Country = country;
            this.PasportID = id;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Сourse { get; set; }
        public string Sex { get; set; }
        public double AverageScore { get; set; }
        public string Country { get; set; }
        public string PasportID { get; set; }

        public void CanDo(){}

        public override string ToString()
        {
            return $"{this.Name}\t{this.LastName}\t{this.Сourse}\t{this.Sex}\t{this.AverageScore}\t{this.Country}\t{this.PasportID}\n";
        }
    }
}