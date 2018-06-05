using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Core.Models
{
    public class MahasiswaModel
    {
        [Key]
        public string Nim { get; set; }
        [Required]
        [MaxLength(50)]
        public string Nama { get; set; }
        [Required]
        [MaxLength(200)]
        public string Alamat { get; set; }
    }
}
