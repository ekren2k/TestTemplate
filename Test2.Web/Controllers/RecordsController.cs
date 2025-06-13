using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test2.DTOs;
using Test2.Models;

namespace Test2.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RecordsController : ControllerBase
{
    
    private readonly IRecordService _recordService;

    public RecordsController(IRecordService recordService)
    {
        _recordService = recordService;
    }

    [HttpPost]
    public async Task<ActionResult<Record>> AddRecordAsync(CreateRecordDto dto)
    {
        var result = await _recordService.AddRecordAsync(dto);
        if (result == false)
            return BadRequest();

        return Created();
    }

    public async Task<IActionResult> GetAllRecordsAsync()
    {
        var records = await _recordService.GetAllRecordsRecordsAsync();
        return Ok(records);
    }
}