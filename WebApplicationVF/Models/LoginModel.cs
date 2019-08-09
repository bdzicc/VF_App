namespace WebApplicationVF.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LoginModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }

}