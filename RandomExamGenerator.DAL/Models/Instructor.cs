﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RandomExamGenerator.DAL.Models;

[Table("Instructor")]
public partial class Instructor
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(20)]
    public string Role { get; set; } = null!;

    [StringLength(6)]
    public string Gender { get; set; } = null!;

    [Column("DepartmentID")]
    public int DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("Instructors")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("InstructorManager")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("Instructor")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    [ForeignKey("Id")]
    [InverseProperty("Instructor")]
    public virtual UserAccount IdNavigation { get; set; } = null!;

    [ForeignKey("Role")]
    [InverseProperty("Instructors")]
    public virtual InstructorRole RoleNavigation { get; set; } = null!;

    [InverseProperty("Instructor")]
    public virtual ICollection<Teach> Teaches { get; set; } = new List<Teach>();

    [InverseProperty("InstructorSupervisorNavigation")]
    public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
}