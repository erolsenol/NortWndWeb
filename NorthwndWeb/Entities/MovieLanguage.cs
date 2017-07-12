using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthwndWeb.Entities
{
    [Table("MovieLanguage")]
    public class MovieLanguage
    {
        [Key]
        [Column("MovieLangId")]
        public int FilmDilId { get; set; }

        [Column("MovieLang")]
        public string FilmDil { get; set; }

        public virtual IList<Movie> Movies { get; set; }

    }
}