﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Slider: IEntitiy
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string? Baslik {  get; set; }
        [StringLength(500)]
        public string? Aciklama { get; set; }
        [StringLength(100)]
        public string? Resim { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }

    }
}
