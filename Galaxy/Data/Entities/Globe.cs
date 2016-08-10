using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Globe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public GlobeType TypeOfGlobe { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Discovered { get; set; }
        public double Distance { get; set; }
    }
}
