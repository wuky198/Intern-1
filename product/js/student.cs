using System.Componentmodel.DataAnnotations;
namespace StudentApp.Models;
public class Studen()
{
    [Key]
    public int Id { get; set; }
    [MaxLength(10)]
    public string Code {get; set; } =string.Empty;
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;
    public DateOnly Birthday { get; set} = DateOnly.MinValue;
    [MaxLeng(255)]
    public string Address {get; set;} = string.Empty;
    public int DepartmentID {get; set;}
    public virtual Department Department{ get; set;} = new();
}


