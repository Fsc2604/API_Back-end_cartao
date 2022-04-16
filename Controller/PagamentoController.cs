using API_cartao1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;

 

namespace API_cartao1.Controllers 
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {  
    

        private readonly AppDbContext _context;
        public PagamentoController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/Pagamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pagamentoo>>> GetPagamentos()
        {
            return await _context.Pagamentos.ToListAsync();
        }
        // GET: api/Pagamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pagamentoo>> GetPagamento(int id)
        {
            var pagamentoo = await _context.Pagamentos.FindAsync(id);
            if (pagamentoo == null)
            {
                return NotFound();
            }
            return pagamentoo;
        }
        // PUT: api/Pagamento/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPagamentoo(int id, Pagamentoo pagamentoo)
        {
            if (id != pagamentoo.Id)
            {
                return BadRequest();
            }
            _context.Entry(pagamentoo).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagamentoExists(id))
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
        // POST: api/Pagamento
        [HttpPost]
        public async Task<ActionResult<Pagamentoo>> PostPagamentoo(Pagamentoo pagamentoo)
        {
            _context.Pagamentos.Add(pagamentoo);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetPagamento", new { id = pagamentoo.Id }, pagamentoo);
        }
        // DELETE: api/Pagamentos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pagamentoo>> DeletePagamentoo(int id)
        {
            var pagamentoo = await _context.Pagamentos.FindAsync(id);
            if (pagamentoo == null)
            {
                return NotFound();
            }
            _context.Pagamentos.Remove(pagamentoo);
            await _context.SaveChangesAsync();
            return pagamentoo;
        }
        private bool PagamentoExists(int id)
        {
            return _context.Pagamentos.Any(e => e.Id == id);
        }
    }
}


