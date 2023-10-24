namespace Laboratorium_2.Models
{
    public class Birth
    {
        public DateTime Date { get; set; }
        public string? Name { get; set; }

        public bool IsValid()
        {
            return Date != null && Name != null;
        }

        public int Calculate()
        {
            return DateTime.Now.Year - Date.Year;
        }
    }
}
