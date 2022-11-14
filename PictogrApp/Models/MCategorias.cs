using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PictogrApp.Models
{
    [Table("Categoria")]
    public class MCategorias
    {
        [PrimaryKey,NotNull,AutoIncrement]
        public int codCat { get; set; }

        [NotNull]
        public string nomCat { get; set; }

        [NotNull]
        public int codUsuario { get; set; }
    }
}
