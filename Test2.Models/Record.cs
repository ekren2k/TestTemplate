using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace Test2.Models;

public class Record
{
    public int Id { get; set; }
    [Length(1,100)]
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public int LanguageId { get; set; }
    public int TaskId { get; set; }
    public int StudentId { get; set; }
    public List<Student> Students { get; set; }
    public List<Language> Languages { get; set; }
    public List<TaskEntity> Tasks { get; set; }
    public long ExecutionTime { get; set; }
}