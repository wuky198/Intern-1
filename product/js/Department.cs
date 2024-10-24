using System.Componentmodel.DataAnnotations;
namespace StudentApp.Models;
public class Department
[Key]
public interface Id{ get; set;}
[Maxlength(50)]
public string Name {get; set;} = string.Empty;
public virtual List<Student> Students{get; set;} = [];
