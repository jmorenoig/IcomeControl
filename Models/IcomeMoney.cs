using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IcomeControl.Models
{
    public class IcomeMoney
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [Display(Name = "Categoria")]
        public Category Category { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime Date { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Display(Name = "Valor")]
        public double Value { get; set; }

    }
}
