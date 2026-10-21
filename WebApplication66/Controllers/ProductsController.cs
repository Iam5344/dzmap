using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Data;
using ProductManagement.DTOs;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products
                .Include(p => p.Images)
                .ToListAsync();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreateDto dto)
        {
            var product = _mapper.Map<Product>(dto);

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            var readDto = _mapper.Map<ProductReadDto>(product);
            return CreatedAtAction(nameof(GetProducts), new { id = readDto.Id }, readDto);
        }
    }
}
