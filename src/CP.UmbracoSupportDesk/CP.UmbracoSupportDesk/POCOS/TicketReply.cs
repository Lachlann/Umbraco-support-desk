using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace CP.UmbracoSupportDesk.POCOS
{
    [TableName("USDTicketReply")]
    [PrimaryKey("ReplyId", autoIncrement = true)]
    public class TicketReply
    {
        [Column("ReplyId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int ReplyId { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }

        [Column("Message")]
        public string Message { get; set; }

        [Column("IsSolution")]
        public bool IsSolution { get; set; }
    }
}