namespace MBX.Application.Features.Categories.DTOs;

public class CategoryDetailsDto : CategoryDto
{
    public CategoryDetailsDto? ParentCategory { get; set; }
    public List<CategoryDto>? ChildCategories { get; set; }
}