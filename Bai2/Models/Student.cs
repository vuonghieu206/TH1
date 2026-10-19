using System.ComponentModel.DataAnnotations;
namespace THLab1.Models;
public class Student
{
    public int Id { get; set; }
    [Display(Name="Họ tên")] public string? Name { get; set; }
    [Display(Name="Email")] public string? Email { get; set; }
    [Display(Name="Mật khẩu")] public string? Password { get; set; }
    [Display(Name="Ngành")] public Branch? Branch { get; set; }
    [Display(Name="Giới tính")] public Gender? Gender { get; set; }
    [Display(Name="Hệ ĐT")] public bool IsRegular { get; set; }
    [Display(Name="Địa chỉ")] public string? Address { get; set; }
    [Display(Name="Ngày sinh")] public DateTime DateOfBirth { get; set; }
    public string? Avatar { get; set; }
}
