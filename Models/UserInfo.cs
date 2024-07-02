using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
  public class UserInfo
  {
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad alanı zorunlu!")] //ErrorMessage yazmazsan ing yazılar gelir
    public string? Name { get; set; }

    [Required(ErrorMessage = "Telefon numarası zorunlu!")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Eposta adresi zorunlu!")]
    [EmailAddress(ErrorMessage = "Eposta adresi hatalı!")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Katılım durumu zorunlu!")]
    public bool? WillAttend { get; set; }

    //reuired yalnızca null durum ile karşılaşınca çalışıyor
    //bool lar için default false int için ise 0 dır
    //yani null gelmez
  }
}