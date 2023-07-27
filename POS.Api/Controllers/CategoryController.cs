using Microsoft.AspNetCore.Mvc;
using POS.Application.Dtos.Request;
using POS.Application.Interfaces;
using POS.Infrastructure.Commons.Bases.Request;

namespace POS.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryApplication _categoryApplication;

    public CategoryController(ICategoryApplication categoryApplication)
    {
        _categoryApplication = categoryApplication;
    }

    [HttpPost]
    public async Task<IActionResult> ListCategories([FromBody] BaseFiltersRequest filter)
    {
        var response = await _categoryApplication.ListCategories(filter);
        return Ok(response);
    }

    [HttpGet("select")]
    public async Task<IActionResult> ListSelectCategories()
    {
        var response = await _categoryApplication.ListSelectCategory();
        return Ok(response);
    }

    [HttpGet("{categoryId:int}")]
    public async Task<IActionResult> CategoryById(int categoryId)
    {
        var response = await _categoryApplication.CategoryById(categoryId);
        return Ok(response);
    }

    [HttpPost("register")]
    public async Task<IActionResult> RegisterCategory([FromBody] CategoryRequestDto requestDto)
    {
        var response = await _categoryApplication.RegisterCategory(requestDto);
        return Ok(response);
    }
    
    [HttpPut("edit/{categoryId:int}")]
    public async Task<IActionResult> EditCategory(int categoryId, [FromBody] CategoryRequestDto requestDto)
    {
        var response = await _categoryApplication.EditCategory(categoryId,requestDto);
        return Ok(response);
    }
    
    [HttpPut("remove/{categoryId:int}")]
    public async Task<IActionResult> RemoveCategory(int categoryId)
    {
        var response = await _categoryApplication.RemoveCategory(categoryId);
        return Ok(response);
    }
    
}