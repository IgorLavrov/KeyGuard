using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace SafeAndroid.Models
{
    [Table("Accounts")]
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SourceName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Link { get; set; }
    }
}
