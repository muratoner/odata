using System.Linq;
using System.Web.OData;
using NetOData.Models;

namespace NetOData.Controllers
{
    public class PageController : ODataController
    {
        MySampleDb _context = new MySampleDb();

        [EnableQuery]
        public IQueryable<Page> Get()
        {
            return _context.Pages;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
