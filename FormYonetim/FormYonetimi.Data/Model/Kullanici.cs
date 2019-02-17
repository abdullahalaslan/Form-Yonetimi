using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormYonetimi.Data.Model
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        public int Yas { get; set; }

        public int FormId { get; set; }

        public Form Form { get; set; }
    }
}
