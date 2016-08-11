using Core.Services;
using System.ComponentModel.DataAnnotations;

namespace Core.DTOModels
{
    public class GlobeDtoModel
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter Name of Globe")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please choose type of Globe")]
        public GlobeTypeDto TypeOfGlobe { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage = "Please enter some description")]
        public string Description { get; set; }
        [DoubleValidation]
        [Required(ErrorMessage = "Please enter distance between Earth and Globe which you add")]
        public double Distance { get; set; }
    }
}
