using System;
using System.Collections.Generic;

namespace Mission08_Team0210.Models;

public partial class Task
{
    public int TaskId { get; set; }

    public string TaskName { get; set; } = null!;

    public string? DueDate { get; set; }

    public string Quadrant { get; set; }

    public int? CategoryId { get; set; }

    public int? Completed { get; set; }

    public virtual Category? Category { get; set; }
}
