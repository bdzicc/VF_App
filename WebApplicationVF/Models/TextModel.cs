namespace WebApplicationVF.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class TextModel : DbContext
    {
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string SMSMessage { get; set; }
    }

}