using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SprayLog.Data.Models
{
    public class Plot
    {
        public int Id { get; init; }

        [Required]
        [StringLength(4, MinimumLength = 2)]
        public string PlotName { get; set; }

        [Required] 
        public int CropId { get; set; }
        public Crop Crop { get; set; }

        public double Area { get; set; }

        public IEnumerable<Crop> Crops { get; set; } = new List<Crop>();

    }
}
