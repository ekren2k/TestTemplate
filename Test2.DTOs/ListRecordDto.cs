using Test2.Models;

namespace Test2.DTOs;

public class ListRecordDto
{
    public int Id { get; set; }
    public Language language { get; set; }
    public TaskEntity Task { get; set; }
    public Student Student { get; set; }
    public long ExecutionTime { get; set; }
    public DateTime Created { get; set; }
}