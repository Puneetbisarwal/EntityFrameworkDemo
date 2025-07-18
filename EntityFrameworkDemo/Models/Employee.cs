using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string Employeename { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Createdon { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Modifiedon { get; set; }

    public string? Modifiedby { get; set; }
}
