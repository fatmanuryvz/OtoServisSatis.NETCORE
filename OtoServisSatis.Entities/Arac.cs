using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntitiy
    {
        public int Id { get; set; }


        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int MarkaId { get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Renk { get; set; }
        [Display(Name = "Fiyat"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public decimal Fiyatı { get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]

        public string Modeli { get; set; }
        [Display(Name = "Kasa Tipi"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
    
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int ModelYili { get; set; }
        [Display(Name = "Satışta mı?"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public bool SatistaMi { get; set; }
        [StringLength(100)]
        public string? Resim1 {  get; set; }
        [StringLength(100)]
        public string? Resim2 { get; set; }
        [StringLength(100)]
        public string? Resim3 { get; set; }
        public string? Notlar { get; set; }
        public virtual Marka? Marka { get; set; }//Araç sınıfı ile Marka sınıfı arasındaki bağlantı.

    }
}
