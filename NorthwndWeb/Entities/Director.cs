using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NorthwndWeb.Entities
{
    [Table("Directors")]
    public class Director
    {
        [Key]
        [Column("directorId")]
        public int directorId { get; set; }

        [Column("directorName")]
        public string directorName { get; set; }

        public virtual IList<Movie> Movies { get; set; }
    }
}