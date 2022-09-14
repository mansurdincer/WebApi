namespace WebApi.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<Category, CategoryDTO>();
        }
    }
}
