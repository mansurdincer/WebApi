namespace WebApi.Data;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDTO>();
        CreateMap<ProductDTO, Product>();
        
        CreateMap<Category, CategoryDTO>();
    }
}
