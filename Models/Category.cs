using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IcomeControl.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        [Display(Name = "Nombre Categoría")]
        public string NameCategory { get; set; }

        [Required]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string Type { get; set; } //IN ingresos GA gastos

        [Required]
        [Display(Name = "Estado")]
        public bool State { get; set; }
    }
}
