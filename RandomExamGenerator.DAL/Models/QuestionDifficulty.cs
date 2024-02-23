﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RandomExamGenerator.DAL.Models;

[Table("QuestionDifficulty")]
public partial class QuestionDifficulty
{
    [Key]
    [Column("QuestionDifficultyID")]
    [StringLength(20)]
    public string QuestionDifficultyId { get; set; } = null!;

    [InverseProperty("QuestionDifficultyNavigation")]
    public virtual ICollection<ExamConfiguration> ExamConfigurations { get; set; } = new List<ExamConfiguration>();

    [InverseProperty("DifficultyNavigation")]
    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}