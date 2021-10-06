namespace ConsoleApplication1.FolderPersonalities
{
    public class Tailor : Ipersonaliti
    {
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
            return $"Name:{this.Name}\tLastName:{this.LastName}\tСourse:{this.Сourse}\tSex:{Sex}\tAverageScore:{AverageScore}\tCountry:{Country}\tPasportID:{PasportID}\n";
        }
    }
}