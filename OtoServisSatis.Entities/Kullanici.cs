using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Kullanici :IEntitiy
    {
        public int Id {  get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"),Required(ErrorMessage ="{0} Boş Bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        [Display(Name = "Soyadı")]
        public string Soyadi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Email {  get; set; }
        [StringLength(30)]
        public string? Telefon {  get; set; }
        [StringLength(30)]
        [Display(Name = "Kullanıcı Adı")] //gelen sayfada KullaniciAdi yazmasın Kullanıcı Adı şeklinde yazsın diye display kullandık!
        public string? KullaniciAdi {  get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Sifre {  get; set; }
        public bool AktifMi { get; set; }
        [Display(Name ="Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;   
        public int RolId {  get; set; }
        public virtual Rol Rol { get; set; }

    }
}
