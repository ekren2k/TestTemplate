using Test2.DTOs;
using Test2.Models;

namespace Test2.Web.Controllers;

public interface IRecordService
{
    public Task<IEnumerable<Record>> GetAllRecordsRecordsAsync();
    
    public Task<bool> AddRecordAsync(CreateRecordDto dto);
}
