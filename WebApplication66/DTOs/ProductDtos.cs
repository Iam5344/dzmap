namespace ProductManagement.DTOs
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; } = new();
    }

    public class ProductCreateDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> ImageUrls { get; set; } = new();
    }
}
