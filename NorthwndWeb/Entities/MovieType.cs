using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWeb.Entities
{
    [Table("MovieType")]
    public class MovieType
    {
        [Key]
        [Column("TypeId")]
        public int MovieTypeId { get; set; }

        [Column("TypeName")]
        public string MovieTypeName { get; set; }

        //[Column("TypeColumn")]
        //public int MovieTypeColumn { get; set; }

        public virtual IList<Movie> Movies { get; set; }
    }
}