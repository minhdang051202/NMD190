using System.ComponentModel.DataAnnotations;
namespace NMD_Ktra.Models
{
    public class Person
    {
        [Key]
        public string HovaTen { get; set; }
        public string TenSinhVien { get; set; }
        public string MaSinhVien { get; set; }
    }
    

}