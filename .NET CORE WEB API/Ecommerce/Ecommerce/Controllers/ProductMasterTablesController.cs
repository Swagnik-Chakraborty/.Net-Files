using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductMasterTablesController : ControllerBase
    {
        private readonly ShoeStopDbContext _context;

        public ProductMasterTablesController(ShoeStopDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductMasterTables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductMasterTable>>> GetProductMasterTables()
        {
          if (_context.ProductMasterTables == null)
          {
              return NotFound();
          }
            return await _context.ProductMasterTables.ToListAsync();
        }

        // GET: api/ProductMasterTables/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductMasterTable>> GetProductMasterTable(int id)
        {
          if (_context.ProductMasterTables == null)
          {
              return NotFound();
          }
            var productMasterTable = await _context.ProductMasterTables.FindAsync(id);

            if (productMasterTable == null)
            {
                return NotFound();
            }

            return productMasterTable;
        }

        // PUT: api/ProductMasterTables/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductMasterTable(int id, ProductMasterTable productMasterTable)
        {
            if (id != productMasterTable.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productMasterTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductMasterTableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductMasterTables
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductMasterTable>> PostProductMasterTable(ProductMasterTable productMasterTable)
        {
          if (_context.ProductMasterTables == null)
          {
              return Problem("Entity set 'ShoeStopDbContext.ProductMasterTables'  is null.");
          }
            _context.ProductMasterTables.Add(productMasterTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductMasterTableExists(productMasterTable.ProductId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductMasterTable", new { id = productMasterTable.ProductId }, productMasterTable);
        }

        // DELETE: api/ProductMasterTables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductMasterTable(int id)
        {
            if (_context.ProductMasterTables == null)
            {
                return NotFound();
            }
            var productMasterTable = await _context.ProductMasterTables.FindAsync(id);
            if (productMasterTable == null)
            {
                return NotFound();
            }

            _context.ProductMasterTables.Remove(productMasterTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductMasterTableExists(int id)
        {
            return (_context.ProductMasterTables?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
