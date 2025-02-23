using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;
public class UserInfo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad ve soyad zorunludur.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Telefon no zorunludur.")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "E-posta adresi zorunludur.")]
    [EmailAddress(ErrorMessage = "E-posta adresi formatı hatalı.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Katılım durumu belirtmek zorunludur.")]
    public bool WillAttend { get; set; }
}
