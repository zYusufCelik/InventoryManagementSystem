using AutoMapper;
using InventoryManagementSystem.Core.Entities;

namespace InventoryManagementSystem.Data.Products
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ProductService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //public List<Product> GetAll()
        //{
        //    var products = _context.Products.ToList();
                

        //    if (products is not null)
        //    {
        //        return products;
        //    }

        //    return null;

        //}
        public List<ProductWithCategoryDto> GetAllProductsWithCategory()
        {
            List<ProductWithCategoryDto> pwc = new List<ProductWithCategoryDto>();

            var result = _context.Products
            .Join(
                _context.Categories, // İkinci tablo
                product => product.CategoryId, // Product tablosundaki bağlanacak sütun
                category => category.Id,    // Category tablosundaki bağlanacak sütun
                (product, category) => new   // Sonuç olarak alınacak veri şekli
                {
                    Id = product.Id,
                    CategoryId = category.Id,
                    CategoryName= category.CategoryName,
                    Name = product.Name,
                    StockQuantity = product.StockQuantity,
                    Description = product.Description
                })
            .ToList();

            var yusuf = _mapper.Map<List<ProductWithCategoryDto>>(result);

            //var products = _context.Products.ToList(); // EF'den veri çekiliyor
            //var productDtos = _mapper.Map<List<ProductDto>>(products); // Liste DTO'ya dönüştürülüyor
            //return productDtos;

            return yusuf;

            //var product = _context.Products.FirstOrDefault(p => p.Id == id);
            //var categories = _context.Categories.FirstOrDefault(p => p.Id == product.CategoryId);

           // return _context.Products.FirstOrDefault(p => p.Id == id);


        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            _context.Remove(id);
        }

       
    }
}
