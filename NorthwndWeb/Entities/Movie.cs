using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NorthwndWeb.Entities
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [Column("filmid")]
        public int FilmId { get; set; }

        [Column("filmresmi")]
        public string FilmResmi { get; set; }

        [Column("filmadi")]
        public string FilmAdi { get; set; }

        [Column("filmpuan")]
        public string FilmPuani { get; set; }

        [Column("filmyili")]
        public string Filmyili { get; set; }

        [Column("filmDili")]
        public int FilmDili { get; set; }

        [Column("filmozet")]
        public string FilmOzet { get; set; }

        [Column("filmtarih")]
        public string FilmEkleTarih { get; set; }

        [Column("directorId")]
        public int FilmYonetmen { get; set; }

        [Column("TypeId")]
        public int FilmTipi { get; set; }

        public virtual MovieType MovieType { get; set; }
        public virtual MovieLanguage MovieLanguage { get; set; }
        public virtual Director Director { get; set; }

        public virtual IList<Comment> Comment { get; set; }
    }
    
}