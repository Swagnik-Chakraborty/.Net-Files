using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeStopController : ControllerBase
    {
        private readonly ShoeStopDbContext _context;
        public ShoeStopController(ShoeStopDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<ActionResult> GetCartItems()
        {
            //var results = _context.Database.SqlQuery<UserData>($"select * from [user] join cart_item on [user].id = cart_item.user_id \r\njoin product on cart_item.product_id = product.id\r\njoin discount on product.discount_id = discount.id\r\njoin user_payment on [user].id = user_payment.user_id\r\nwhere [user].id=1;");
            //var results1 = _context.Users.FromSql($"select * from [user]");
            var result = from ProductMasterTable in _context.ProductMasterTables
                         join PaymentDetail in _context.PaymentDetails on ProductMasterTable.ProductId equals PaymentDetail.ProductId
                         join OrderDetail in _context.OrderDetails on ProductMasterTable.ProductId equals OrderDetail.ProductId
                         where ProductMasterTable.ProductId >=1
                         select new
                         {
                             ProductMasterTable.ProductId,
                             ProductMasterTable.ProductName,
                             ProductMasterTable.ProductPrice,
                             ProductMasterTable.ProductDesacription,
                             ProductMasterTable.ProductStock,
                             ProductMasterTable.ProductGender,
                             ProductMasterTable.ProductBrand,
                             ProductMasterTable.ProductCategory,
                             PaymentDetail.PaymentType,
                             OrderDetail.Discount,
                             OrderDetail.TotalAmount




                         };




            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();

        }
    }
}
