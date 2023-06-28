namespace BackendProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string FirstImageUrl { get; set; }
        public string SecondImageUrl { get; set; }
        public int StarCount { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public string BottomFirstImageUrl { get; set; }
        public string BottomSecondImageUrl { get; set; }
        public int BottomStarCount { get; set; }

        public string BottomTitle { get; set; }
        public double BottomPrice { get; set; }

    }
}
