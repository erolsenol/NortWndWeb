using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWeb.Entities
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("Uname")]
        public string UserName { get; set; }

        [Column("Umail")]
        public string UserMail { get; set; }

        [Column("Upass")]
        public string UserPass { get; set; }

    }
}