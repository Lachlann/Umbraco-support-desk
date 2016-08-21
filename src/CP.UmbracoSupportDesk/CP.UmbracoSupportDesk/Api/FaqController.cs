
using CP.UmbracoSupportDesk.POCOS;
using CP.UmbracoSupportDesk.Repository;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;

namespace CP.UmbracoSupportDesk.Api
{
    public class FaqController
    {
        public HttpResponseMessage AddBooking(Faq faqItem)
        {
            HttpContext.Current.Response.ContentType = "application/json";
            Faq createdItem = Faqs.Save(faqItem);
            if (createdItem != null)
            {
                HttpContext.Current.Response.StatusCode = 200;  
            }
            else {
                HttpContext.Current.Response.StatusCode = 500;
            }
            HttpContext.Current.Response.Write(new JavaScriptSerializer().Serialize(createdItem));
            return new HttpResponseMessage();
        }

    }
}