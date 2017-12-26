using System.Linq;
using System.Web.OData;
using NetOData.Models;

namespace NetOData.Controllers
{
    public class SurveyItemController : ODataController
    {
        MySampleDb _context = new MySampleDb();

        [EnableQuery]
        public IQueryable<SurveyItem> Get()
        {
            return _context.SurveyItems;
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
