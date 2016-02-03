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
        [Display(Name = "Fecha Inicio")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime FechaInicio { get; set; }

        [Column("FECHA_FIN")]
        [Display(Name = "Fecha Fin")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime FechaFin { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
