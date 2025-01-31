using System;

namespace dziennikzywieniowy.Models
{
    public class CaloricDeficit
    {
        public int Id { get; set; } // Klucz główny
        public string ActivityName { get; set; } = string.Empty; // Nazwa aktywności
        public DateTime Date { get; set; } = DateTime.Now; // Data aktywności
        public int CaloriesBurned { get; set; } // Spalone kalorie
    }
}
