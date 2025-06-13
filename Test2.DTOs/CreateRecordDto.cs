using System.ComponentModel.DataAnnotations;
using Test2.Models;

namespace Test2.DTOs;

public class CreateRecordDto
{
    [Required]
    public int LanguageId { get; set; }
    [Required]
    public int StudentId { get; set; }
    [Required]
    public int TaskId { get; set; }
    [Required]
    public long ExecutionTime {get; set;}
    public DateTime Created { get; set; }
}