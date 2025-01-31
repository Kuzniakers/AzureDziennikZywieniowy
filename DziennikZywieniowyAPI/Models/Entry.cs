namespace dziennikzywieniowyAPI.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string MealName { get; set; } = string.Empty; 
        public DateTime Date { get; set; } = DateTime.Now;
        public int Calories { get; set; }
    }
}
