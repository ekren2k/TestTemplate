using Microsoft.EntityFrameworkCore;
using Test2.Context;
using Test2.DTOs;
using Test2.Models;
using Test2.Web.Controllers;

namespace Test2.Services;

public class RecordService : IRecordService
{
    private readonly MasterContext _context;

    public RecordService(MasterContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Record>> GetAllRecordsRecordsAsync()
    {
        IQueryable<Record> query = _context.Records;

        query.Include(l => l.Languages)
            .Include(s => s.Students)
            .Include(t => t.Tasks)
            .OrderByDescending(r => r.CreatedAt)
            .ThenByDescending(s => s.Students.OrderBy(s => s.LastName));
        
        return await query.ToListAsync();

    }

    public async Task<bool> AddRecordAsync(CreateRecordDto dto)
    {
        var exists = await _context.Records
            .AnyAsync(s => s.StudentId == dto.StudentId && s.LanguageId == dto.LanguageId);


        var existsTaskId = await _context.Records
            .AnyAsync(t => t.TaskId == dto.TaskId);
        
        if (!exists)
            return false;
        
        if (!existsTaskId)
            return false;
                
        Record record = new Record
        {
            StudentId = dto.StudentId,
            LanguageId = dto.LanguageId,
            TaskId = dto.TaskId,
            CreatedAt = dto.Created,
            ExecutionTime = dto.ExecutionTime,
        };

    _context.Records.Add(record);
    await _context.SaveChangesAsync();
    return true;
}
}