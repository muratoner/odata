using System.Linq;
using System.Web.OData;
using System.Web.OData.Query;
using NetOData.Models;

namespace NetOData.Controllers
{
    public class SurveyController : ODataController
    {
        MySampleDb _context = new MySampleDb();

        [EnableQuery(AllowedQueryOptions = AllowedQueryOptions.All)]
        public IQueryable<Survey> Get()
        {
            return _context.Surveys;
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
