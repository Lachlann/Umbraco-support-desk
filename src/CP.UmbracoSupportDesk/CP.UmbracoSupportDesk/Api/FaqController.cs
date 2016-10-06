
using CP.UmbracoSupportDesk.POCOS;
using CP.UmbracoSupportDesk.Repository;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using Umbraco.Web.WebApi;

namespace CP.UmbracoSupportDesk.Api
{
    public class FaqController : UmbracoApiController
    {
        public HttpResponseMessage AddFAQ(Faq faqItem)
        {
            HttpContext.Current.Response.ContentType = "application/json";
            Faq createdItem = Faqs.Save(faqItem);
            List<Faq> allItems = new List<Faq>();
            if (createdItem != null)
            {
                HttpContext.Current.Response.StatusCode = 200;
                allItems = Faqs.GetAll();
            }
            else {
                HttpContext.Current.Response.StatusCode = 500;

            }
            HttpContext.Current.Response.Write(new JavaScriptSerializer().Serialize(allItems));
            return new HttpResponseMessage();
        }
        public HttpResponseMessage GetAllFaqs() {
            HttpContext.Current.Response.ContentType = "application/json";
            List<Faq> allItems = Faqs.GetAll();
            HttpContext.Current.Response.StatusCode = 200;
            HttpContext.Current.Response.Write(new JavaScriptSerializer().Serialize(allItems));
            return new HttpResponseMessage();
        }
        public HttpResponseMessage UpdateFaq(Faq item)
        {
            HttpContext.Current.Response.ContentType = "application/json";
            Faq updatedItem = Faqs.UpdateFAQ(item);

            List<Faq> allItems = new List<Faq>();
            if (updatedItem != null)
            {
                HttpContext.Current.Response.StatusCode = 200;
                allItems = Faqs.GetAll();
            }
            else
            {
                HttpContext.Current.Response.StatusCode = 500;

            }
            HttpContext.Current.Response.Write(new JavaScriptSerializer().Serialize(allItems));
            return new HttpResponseMessage();
        }


    }
}