using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entities
{
    public  class PersonelBilgi
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(11)]
        [Required]
        public string TcKimlikNo { get; set; }

        [StringLength(50)]
        [Required]
        public string Ad { get; set; }

        [StringLength(50)]
        [Required]
        public string Soyad { get; set; }

        [Required]
        [EmailAddress]
        public string Eposta { get; set; }

        [Required]
        public DateTime KayitTarihi { get; set; }

    }

}
