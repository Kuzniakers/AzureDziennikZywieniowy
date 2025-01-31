using System;

namespace dziennikzywieniowyAPI.Models
{
    public class CaloricDeficit
    {
        public int Id { get; set; }
        public string ActivityName { get; set; } 
        public int CaloriesBurned { get; set; } 
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
