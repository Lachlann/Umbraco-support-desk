using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace CP.UmbracoSupportDesk.POCOS
{
    [TableName("USDFaq")]
    [PrimaryKey("FaqId", autoIncrement = true)]
    public class Faq
    {
        [Column("FaqId")]
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int TicketID { get; set; }

        [Column("Question")]
        public string Question { get; set; }

        [Column("User")]
        public int User { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Answer")] //String of ids
        [SpecialDbType(SpecialDbTypes.NTEXT)]
        public string Answer { get; set; }
    }
}