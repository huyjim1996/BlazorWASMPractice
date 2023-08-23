using System;
using System.Collections.Generic;

namespace BlogBlazor.Shared.ModelEF;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Department { get; set; }

    public string? Position { get; set; }
}
