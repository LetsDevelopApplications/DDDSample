namespace PFMSAPI.Models
{

    public class ProductFeature
    {
        public int Id { get; set; }
        public string FeatureTitle { get; set; }
        public string Description { get; set; }
        public string estCapacity { get; set; }
        
        public string status { get; set; }
        public string targetCompDate { get; set; }
        public string ActualCompDate { get; set; }
       
    }
}
