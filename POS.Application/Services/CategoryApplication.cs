using AutoMapper;
using POS.Application.Commons.Bases;
using POS.Application.Dtos.Request;
using POS.Application.Dtos.Response;
using POS.Application.Interfaces;
using POS.Application.Validators.Category;
using POS.Infrastructure.Commons.Bases.Request;
using POS.Infrastructure.Commons.Bases.Response;
using POS.Infrastructure.Persistence.Interfaces;

namespace POS.Application.Services;

public class CategoryApplication : ICategoryApplication
{
    private IUnitOfWork _unitOfWork;
    private IMapper _mapper;
    private readonly CategoryValidator _validationRules;

    public CategoryApplication(IUnitOfWork unitOfWork, IMapper mapper, CategoryValidator validationRules)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _validationRules = validationRules;
    }


    public async Task<BaseResponse<BaseEntityResponse<CategoryResponseDto>>> ListCategories(BaseFiltersRequest filters)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<IEnumerable<CategorySelectResponseDto>>> ListSelectCategory()
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<CategoryResponseDto>> CategoryById(int categoryId)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDto requestDto)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDto requestDto)
    {
        throw new NotImplementedException();
    }

    public async Task<BaseResponse<bool>> RemoveCategory(int categoryId)
    {
        throw new NotImplementedException();
    }
}