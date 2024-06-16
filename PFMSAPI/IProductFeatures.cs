using Microsoft.AspNetCore.Mvc;
using PFMSAPI.Models;

namespace PFMSAPI
{
    public interface IProductFeatures
    {
        public List<ProductFeature> GetProductFeatures();
        public Task<ProductFeature> AddProductFeature(ProductFeature feature);

        public Task<bool> EditProductFeature(ProductFeature feature);
        public Task<bool> DeleteProductFeature(ProductFeature feature);
    
    }
 
}
