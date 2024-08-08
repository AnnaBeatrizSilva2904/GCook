using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("Receita")]
public class Receita
{
    [Key]
    public int MyProperty { get; set; }
}
