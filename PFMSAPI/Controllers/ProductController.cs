using eCommerce.WebService.Models;
using eCommerce.ApplicationLayer.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PFMSAPI.Controllers
{
    public class ProductController : ApiController
    {

        readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public Response<ProductDto> Add([FromUri] ProductDto productDto)
        {
            Response<ProductDto> response = new Response<ProductDto>();
            try
            {
                response.Object = this.productService.Add(productDto);
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        [HttpGet]
        public Response<ProductDto> Get(Guid id)
        {
            Response<ProductDto> response = new Response<ProductDto>();
            try
            {
                response.Object = this.productService.Get(id);
            }
            catch (Exception ex)
            {
                //log error
                response.Errored = true;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
