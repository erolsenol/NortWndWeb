using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWeb.Entities
{
    [Table("Chats")]
    public class Chat
    {
        [Key]
        [Column("chatId")]
        public int chatId { get; set; }

        [Column("chatMessage")]
        public string chatMessage { get; set; }

        [Column("userName")]
        public string userName { get; set; }

        [Column("chatDate")]
        public DateTime chatDate { get; set; }
    }
}