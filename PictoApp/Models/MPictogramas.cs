﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PictoApp.Models
{
    [Table("Pictogramas")]
    public class MPictogramas
    {
        [PrimaryKey, NotNull, AutoIncrement]
        public int CodPicto { get; set; }

        [NotNull, MaxLength(100)]
        public string NomPicto { get; set; }

        [NotNull, MaxLength(550)]
        public string TextoPicto { get; set; }

        [NotNull]
        public string Picto { get; set; }

        [NotNull]
        public int CodCat { get; set; } 

    }
}
