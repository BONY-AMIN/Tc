using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tc.Domain.ViewModels
{
    public class Voter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Education { get; set; }
        public string Gendar { get; set; }

        public int Quantity { get; set; }
    }
}
