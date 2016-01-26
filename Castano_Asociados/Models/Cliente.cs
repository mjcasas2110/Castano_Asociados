using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Castano_Asociados.Models
{
    [Table("CLIENTE")]
    public class Cliente
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("NOMBRE")]
        public string Nombre { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PAGINA_WEB")]
        [Display(Name="Pagina Web")]
        public string Pagina_Web { get; set; }

        public virtual ICollection<Evento> Eventos { get; set; }

        public Cliente()
        {
            Eventos = new HashSet<Evento>();
        }
    }
}
