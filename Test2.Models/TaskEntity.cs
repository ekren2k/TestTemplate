using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class TaskEntity
{
    public int Id { get; set; }
    [Length(1,100)]
    public string Name { get; set; }
    [Length(1,2000)]
    public string Description { get; set; }
    public Record Record { get; set; }
}