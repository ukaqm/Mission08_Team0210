using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08_Team0210.Models;

public partial class Task
{
    [Key]
    [Required]
    public int TaskId { get; set; }
    
    [Required(ErrorMessage = "Task Name is required.")]
    public string TaskName { get; set; } = null!;

    public string? DueDate { get; set; }
    
    [Required(ErrorMessage = "Quadrant is required.")]
    public string Quadrant { get; set; }
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }

    public bool? Completed { get; set; }

    public virtual Category? Category { get; set; }
}
