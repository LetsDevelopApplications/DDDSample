using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Helpers.Domain;

namespace eCommerce.DomainModelLayer.Products
{
    public class Product : IAggregateRoot
    {
        private List<Return> returns = new List<Return>();

        public virtual Guid Id { get; protected set; }
    }
}
