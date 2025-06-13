using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Language
{
    public int Id { get; set; }
    [Length(1,100)]
    public string Name { get; set; }
    public Record Record { get; set; }
}