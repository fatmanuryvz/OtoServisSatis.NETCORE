﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Musteri: IEntitiy
    {
        public int Id { get; set; }
        [Display(Name = "Araç No")]
       
        public int AracId {  get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50) ,Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        [Display(Name = "Soyadı")]
        public string Soyadi {  get; set; }
        [StringLength(11)]
        [Display(Name = "TC Numarası")]
        public string? TcNo {  get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email {  get; set; }
        [StringLength(200)]
        public string? Adres {  get; set; }
        [StringLength(11)]
        public string? Telefon {  get; set; }
        public string? Notlar {  get; set; }
        public virtual Arac? Arac {get; set; }

    }
} 
