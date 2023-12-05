using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models;

public class TodoItem
{
    [Key]
    public int Id { get; set; }
    [Required]
    [Column(TypeName = "varchar(100)")]
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}