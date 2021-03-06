using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB;
using Domain;

namespace WeChipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertasController : ControllerBase
    {
        private readonly WeChipContext _context;

        public OfertasController(WeChipContext context)
        {
            _context = context;
        }

        // GET: api/Ofertas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Oferta>>> GetOfertas()
        {
            return await _context.Ofertas.Include("OfertaItems.Produto").Include(c => c.Cliente).ToListAsync();
        }

        // GET: api/Ofertas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Oferta>> GetOferta(int id)
        {
            var oferta = await _context.Ofertas.Include("OfertaItems.Produto").Include(c => c.Cliente).FirstOrDefaultAsync(o => o.Id == id);

            if (oferta == null)
            {
                return NotFound();
            }

            return oferta;
        }

        // GET: api/Ofertas/5
        //[HttpGet("{Produto}")]
        //public async Task<ActionResult<Oferta>> GetOferta(string produto)
        //{
        //    var oferta = await _context.Ofertas.Where(o => o.OfertaItems.Where(i => i.Produto.Descricao.Contains(produto))).Include("OfertaItems.Produto").Include(c => c.Cliente);

        //    if (oferta == null)
        //    {
        //        return NotFound();
        //    }

        //    return oferta;
        //}

        // PUT: api/Ofertas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOferta(int id, Oferta oferta)
        {
            if (id != oferta.Id)
            {
                return BadRequest();
            }

            _context.Entry(oferta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaExists(id))
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

        // POST: api/Ofertas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Oferta>> PostOferta(Oferta oferta)
        {
            _context.Ofertas.Add(oferta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOferta", new { id = oferta.Id }, oferta);
        }

        // DELETE: api/Ofertas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Oferta>> DeleteOferta(int id)
        {
            var oferta = await _context.Ofertas.FindAsync(id);
            if (oferta == null)
            {
                return NotFound();
            }

            _context.Ofertas.Remove(oferta);
            await _context.SaveChangesAsync();

            return oferta;
        }

        private bool OfertaExists(int id)
        {
            return _context.Ofertas.Any(e => e.Id == id);
        }
    }
}
