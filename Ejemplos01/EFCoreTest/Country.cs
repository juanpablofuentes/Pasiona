using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTest
{
    internal class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }

        [Timestamp]
        public DateTime LastUpdate { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
