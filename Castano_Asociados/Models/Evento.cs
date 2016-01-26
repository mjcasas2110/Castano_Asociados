using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Castano_Asociados.Models
{
    [Table("EVENTO")]
    public class Evento
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("ID_CLIENTE")]
        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }

        [Column("FECHA_INICIO")]
        public DateTime Fecha_Inicio { get; set; }

        [Column("FECHA_FIN")]
        public DateTime Fecha_Fin { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
