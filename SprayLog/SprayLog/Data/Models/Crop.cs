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

        [Required]
        public int PesticideSolutionTypeId { get; set; }
        public PesticideSolutionType SolutionType { get; set; }

        //public IEnumerable<Plot> Plots { get; set; } = new List<Plot>();
    }
}
