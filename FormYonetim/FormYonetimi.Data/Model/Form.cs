using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormYonetimi.Data.Model
{
    [Table("Form")]

    public class Form
    {
        [Key]
        public int FormId { get; set; }

        public string FormName { get; set; }

        [MinLength(3, ErrorMessage = "Lütfen 3 karakterden fazla değer giriniz  !"),MaxLength(150, ErrorMessage = "Lütfen 150 karakterden fazla değer girmeyiniz  !")]
        public string FormDescription { get; set; }

        public DateTime? CreatedAt { get; set; }

        [ForeignKey("Admin")]
        public int CreatedById { get; set; }

        public ICollection<Kullanici> Kullanici { get; set; }

        public Admin Admin { get; set; }
    }
}
