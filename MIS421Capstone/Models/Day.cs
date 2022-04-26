namespace MIS421Capstone.Models
{
    public class Day
    {

        public int Id { get; set; }
        public DateTime  date { get; set; }
        public List<Food> Foods { get; set; }

        public List<Workout> workout { get; set; }

        public String Journal { get; set;}
    }
}
