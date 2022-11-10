using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PictoApp.Models
{
    [Table("Usuarios")]
    public class MUsuarios
    {
        [PrimaryKey, NotNull, AutoIncrement]
        public int CodUser { get; set; }

        [NotNull, MaxLength(100)]
        public string Email { get; set; }

        [NotNull, MaxLength(550)]
        public string NomUser { get; set; }

        [NotNull, MaxLength(30)]
        public string Contrasena { get; set; }

    }
}
