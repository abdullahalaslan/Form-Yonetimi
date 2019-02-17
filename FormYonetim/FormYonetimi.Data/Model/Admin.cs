using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormYonetimi.Data.Model
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "Lütfen 16 karakterden fazla değer girmeyiniz  !")]
        public string Password { get; set; }

        public ICollection<Form> Form { get; set; }
    }
}
