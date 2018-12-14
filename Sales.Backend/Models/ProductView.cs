namespace Sales.Backend.Models
{
    using Common.Models;
    using System.Web;

    public class ProductView: Product
    {
        public HttpPostedFileBase ImageFile { get; set; }
    }
}