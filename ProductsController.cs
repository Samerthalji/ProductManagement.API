using Microsoft.AspNetCore.Mvc;
using FirstProject.Dtos;

using Microsoft.AspNetCore.Authorization;
using FirstProject.Modules;
using System.Security.Claims;


namespace FirstProject.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class ProductsController(ApplicationDbContext context) : ControllerBase
    {
        [HttpPost]
        [Route("AddProduct")]
        [Authorize(Roles = "Admin")]
        public IActionResult AddProduct(CreateProduct product)
        {
            var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if(String.IsNullOrEmpty(userIdClaim)||!int.TryParse(userIdClaim, out int userId)) {
                return BadRequest("Invalid user ID");
            }
            var profuctdot = new Modules.Product
            {
                Name = product.name,
                Price = product.price,
                UserId = int.Parse(userIdClaim),

            };
            context.Products.Add(profuctdot);
            context.SaveChanges();
            return Ok("تم إضافة المنتج بنجاح.");
        }
        [HttpPut("UpdateProduct/{id}")]
        [Authorize(Roles= "Admin")]
        public IActionResult ModifyProduct(int id,UpdateProduct product)
        {
            var ifexist = context.Products.FirstOrDefault(p => p.Id == id);
            if (ifexist==null)
            {
                return NotFound("لا يوجد عنصر للتعديل");
            }
            ifexist.Name = product.name;
            ifexist.Price = product.price;
            context.SaveChanges();
            return Ok("تم التعديل");
        }
        [HttpDelete("DeleteProduct/{id}")]
        
        public IActionResult DeleteProduct(int id)
        {
            var exsistting = context.Products.FirstOrDefault(p => p.Id == id);
                if (exsistting != null)
            {
                context.Products.Remove(exsistting);
                context.SaveChanges();
                
                return Ok("تم الحذف");
            }
            return NotFound("لا يوجد عنصر للحذف");
        }
        [HttpGet("GetAllProducts")]
        public IActionResult GetAllproducts()
        {
            var Allproducts = context.Products.Select(n =>new ReadProduct
            {
                name=n.Name,
                price=n.Price
            }).ToList();
           
               
                return Ok(Allproducts);
                
            
        }
        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound("المنتج غير موجود");
            }
            var productDto = new ReadProduct
            {
                name = product.Name,
                price = product.Price
            };
            return Ok(productDto);
        }

    }
}
