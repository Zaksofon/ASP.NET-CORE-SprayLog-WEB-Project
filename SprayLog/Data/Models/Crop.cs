using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SprayLog.Data.Models
{
    public class Crop
    {
        public int Id { get; init; }

        [Required]
        [StringLength(4, MinimumLength = 2)]
        public string CropName { get; set; }

        public DateTime PlantedOn { get; set; }

        public int Batch { get; set; }

        //[Required]
        //public int PlotId { get; set; }
        //public Plot Plot { get; set; }

        //public IEnumerable<Plot> Plots { get; set; } = new List<Plot>();
    }
}
