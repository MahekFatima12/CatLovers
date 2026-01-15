namespace CatLoversWeb.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Breed { get; set; } = string.Empty;
        public int Age { get; set; }
        public string ImageUrl { get; set; }
        // Pricing
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }  // optional
        public bool IsAvailable { get; set; }         // In Stock / Reserved
    }
}
