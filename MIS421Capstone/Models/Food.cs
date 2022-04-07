namespace MIS421Capstone.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public int protein  { get; set; }
        public int fat { get ; set; }
        public int carbs { get; set; }
        public DateTime TimeConsumed { get; set; } 
    }
}
