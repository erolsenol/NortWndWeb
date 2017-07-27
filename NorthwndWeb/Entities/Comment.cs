using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWeb.Entities
{
    [Table("Comments")]
    public class Comment
    {
        [Key]
        [Column("CommentId")]
        public int yorumId { get; set; }

        [Column("filmid")]
        public int filmIdComment { get; set; }

        [Column("filmComment")]
        public string yorum { get; set; }

        [Column("nick")]
        public string nick { get; set; }

        public virtual Movie Movie { get; set; }
    }
}