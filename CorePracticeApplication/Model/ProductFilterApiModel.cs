namespace CorePracticeApplication.Model
{
    public class ProductFilterApiModel:BaseFilterApiModel
    {
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public int Cost { get; set; }
    }
}
