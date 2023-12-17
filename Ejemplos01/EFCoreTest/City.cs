using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }

        [Timestamp]
        public DateTime LastUpdate { get; set; }

        public Country Country { get; set; }
    }
}
