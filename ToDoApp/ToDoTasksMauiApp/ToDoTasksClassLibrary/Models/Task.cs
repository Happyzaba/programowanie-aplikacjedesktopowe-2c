using System;
using System.Collections.Generic;

namespace ToDoTasksClassLibrary.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public bool IsDone { get; set; }

    public bool IsDeleted { get; set; }
}
