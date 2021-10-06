namespace ConsoleApplication1.FolderPersonalities
{
    public interface Ipersonaliti
    {
        string Name { get; set;}
        string LastName { get; set;}
        int Сourse { get; set;}
        string Sex { get; set;}
        double AverageScore { get; set;}
        string Country { get; set;}
        string PasportID { get; set;}
        void CanDo();
    }
}