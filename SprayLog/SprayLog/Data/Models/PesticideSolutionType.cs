using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SprayLog.Data.Models
{
    public class PesticideSolutionType
    {
        public int Id { get; init; }

        [Required]
        public string PesticideType { get; set; }

        public IEnumerable<Crop> Crops { get; init; } = new List<Crop>();
    }
}
