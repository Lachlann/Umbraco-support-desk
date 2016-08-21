using Umbraco.Core;
using Umbraco.Core.Persistence;
using CP.UmbracoSupportDesk.POCOS;

namespace CP.UmbracoSupportDesk.ApplicationEvents
{
    public class CreateTables : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var ctx = applicationContext.DatabaseContext;
            var db = new DatabaseSchemaHelper(ctx.Database, applicationContext.ProfilingLogger.Logger, ctx.SqlSyntax);

            if (!db.TableExist("USDTicket"))
            {
                db.CreateTable<Ticket>(false);
            }
            if (!db.TableExist("USDTicketReply"))
            {
                db.CreateTable<TicketReply>(false);
            }
            if (!db.TableExist("USDFaq"))
            {
                db.CreateTable<Faq>(false);
            }
        }
    }
}