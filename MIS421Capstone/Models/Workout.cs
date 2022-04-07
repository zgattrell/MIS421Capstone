namespace MIS421Capstone.Models
{
    public class Workout
    {

        public int Id { get; set; }
        public DateOnly date { get; set; }

        public List<Exercise> exercises { get; set; }

    }
}
