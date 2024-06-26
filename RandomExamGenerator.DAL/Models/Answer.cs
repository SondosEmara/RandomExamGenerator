﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RandomExamGenerator.DAL.Models;

[PrimaryKey("StudentId", "ExamId", "QuestionId")]
[Table("Answer")]
public partial class Answer
{
    [Key]
    [Column("StudentID")]
    public int StudentId { get; set; }

    [Key]
    [Column("ExamID")]
    public int ExamId { get; set; }

    [Key]
    [Column("QuestionID")]
    public int QuestionId { get; set; }

    /// <summary>
    /// Represents OrderInQuestion for the choice marked as the answer for this (Single Choice,T/F) Question.
    /// </summary>
    public int ModelAnswer { get; set; }

    /// <summary>
    /// Represents OrderInQuestion for the choice marked the student selected as his answer fort his (Single Choice,T/F) Question.
    /// </summary>
    public int StudentAnswer { get; set; }

    public int Grade { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Answers")]
    public virtual Exam Exam { get; set; } = null!;

    [ForeignKey("QuestionId")]
    [InverseProperty("Answers")]
    public virtual Question Question { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Answers")]
    public virtual Student Student { get; set; } = null!;
}