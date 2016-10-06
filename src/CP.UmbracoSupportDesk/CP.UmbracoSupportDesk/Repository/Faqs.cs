using CP.UmbracoSupportDesk.POCOS;
using System.Collections.Generic;
using Umbraco.Core.Persistence;
using System;


namespace CP.UmbracoSupportDesk.Repository
{
    public class Faqs
    {
        private static UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
        public static Faq Save(Faq item)
        {
            using (var uow = db.GetTransaction())
            {
                db.Save(item);
                uow.Complete();
                return item;
            }
        }
        public static List<Faq> GetAll() {
            return db.Fetch<Faq>("SELECT * FROM USDFaq ORDER BY FaqId");
        }
        public static Faq UpdateFAQ(Faq item)
        {
            db.Update(item);
            return item;
        }
    }
}