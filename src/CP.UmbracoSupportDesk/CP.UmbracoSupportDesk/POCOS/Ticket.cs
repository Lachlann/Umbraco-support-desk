using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace CP.UmbracoSupportDesk.POCOS
{
    [TableName("USDTicket")]
    [PrimaryKey("TicketId", autoIncrement = true)]
    public class Ticket
    {
        [Column("TicketID")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int TicketID { get; set; }

        [Column("Message")]
        public string Message{ get; set; }

        [Column("User")]
        public int User { get; set; }

        [Column("NodeId")]
        public int NodeId { get; set; }

        [Column("UserData")]
        public int UserData { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Private")]
        public bool Private { get; set; }

        [Column("Replies")] //String of ids
        public string Replies{ get; set; }
    }
}