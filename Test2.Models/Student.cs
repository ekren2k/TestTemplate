using System.ComponentModel.DataAnnotations;

namespace Test2.Models;

public class Student
{
    public int Id { get; set; }
    [Length(1,100)]
    public string FirstName { get; set; }
    [Length(1,100)]
    public string LastName { get; set; }
    [Length(1,250)]
    public string Email { get; set; }
    public Record Record { get; set; }
}