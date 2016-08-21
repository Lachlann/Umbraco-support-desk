using CP.UmbracoSupportDesk.POCOS;
using System.Collections.Generic;
using Umbraco.Core.Persistence;
using System;


namespace CP.UmbracoSupportDesk.Repository
{
    public class Faqs
    {
        public static Faq Save(Faq item)
        {
            UmbracoDatabase db = Umbraco.Core.ApplicationContext.Current.DatabaseContext.Database;
            using (var uow = db.GetTransaction())
            {
                db.Save(item);
                uow.Complete();
                return item;
            }
        }
    }
}