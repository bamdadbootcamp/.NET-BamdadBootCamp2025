using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.DTOs.Languages
{
    public class UpdateLanguageDto
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
    }
}
