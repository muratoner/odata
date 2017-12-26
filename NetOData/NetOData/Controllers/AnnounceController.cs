using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using NetOData.Models;

namespace NetOData.Controllers
{
    public class AnnounceController : ODataController
    {
        MySampleDb context = new MySampleDb();

        [EnableQuery(PageSize = 10, MaxExpansionDepth = 2, AllowedFunctions = AllowedFunctions.All)]
        public IHttpActionResult Get()
        {
            return Ok(context.Announces);
        }

        public async Task<IHttpActionResult> Post([FromBody] Announce entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Announces.Add(entity);
            await context.SaveChangesAsync();
            return Created(entity);
        }

        public async Task<IHttpActionResult> Put([FromODataUri] int key, [FromBody] Announce entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (key != entity.ID)
            {
                return BadRequest("The key from the url must match the key of the entity in the body");
            }
            var originalCustomer = await context.Announces.FindAsync(key);
            if (originalCustomer == null)
            {
                return NotFound();
            }
            else
            {
                context.Entry(originalCustomer).CurrentValues.SetValues(entity);
                await context.SaveChangesAsync();
            }
            return Updated(entity);
        }

        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Announce> patch)
        {
            object id;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else if (patch.TryGetPropertyValue("Id", out id) && (int)id != key)
            {
                return BadRequest("The key from the url must match the key of the entity in the body");
            }
            var originalEntity = await context.Announces.FindAsync(key);
            if (originalEntity == null)
            {
                return NotFound();
            }
            else
            {
                patch.Patch(originalEntity);
                await context.SaveChangesAsync();
            }
            return Updated(originalEntity);
        }


        public async Task<IHttpActionResult> Delete([FromODataUri]int key)
        {
            var entity = await context.Announces.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            else
            {
                context.Announces.Remove(entity);
                await context.SaveChangesAsync();
                return StatusCode(HttpStatusCode.NoContent);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }
    }
}