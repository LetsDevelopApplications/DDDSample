using PFMSAPI.Models;
using Microsoft.EntityFrameworkCore;
using PFMSAPI.Controllers.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Mvc;

namespace PFMSAPI
{
    public class ProductFeaturesRepository :IProductFeatures
    {
     
            public ProductFeaturesRepository()
            {
            using var context = new ProductFeaturesDBContext();
            var productfeatures = new List<ProductFeature>
                {
                    new ProductFeature
                    {
                        FeatureTitle ="Inventory change",
                        Description ="Inventory change notification",
                        estCapacity="S",
                        status="New",
                        targetCompDate="10-Jun-2024",
                        ActualCompDate="12-Jun-2024"

                    },
                    new ProductFeature
                    {
                      FeatureTitle ="User settings",
                        Description ="User settings are persisted",
                        estCapacity="M",
                        status="Active",
                        targetCompDate="10-May-2024",
                        ActualCompDate="12-Oct-2024"
                    }
                };
            
            if (context.ProductFeatures.ToList().Count() == 0)
                context.ProductFeatures.AddRange(productfeatures);
            if (context.HasChanges())
                context.SaveChanges();
        }
        public List<ProductFeature> GetProductFeatures()
        {
                using var context = new ProductFeaturesDBContext();
                var list = context.ProductFeatures
                    .ToList();
                return list;
        }


        public async Task<ProductFeature> AddProductFeature(ProductFeature feature)
        {
            using var context = new ProductFeaturesDBContext();
            context.ProductFeatures.AddRange(feature);
            await context.SaveChangesAsync();
            return feature;
        }

        public async Task<bool> EditProductFeature(ProductFeature featurerequest)
        {
            using var context = new ProductFeaturesDBContext();
            context.ProductFeatures.Update(featurerequest);
            await context.SaveChangesAsync();
           return true;
        }

        public async Task<bool> DeleteProductFeature(ProductFeature feature)
        {
            using var context = new ProductFeaturesDBContext();
            context.ProductFeatures.Remove(feature);

            await context.SaveChangesAsync();

            return true;
        }


    }
}
