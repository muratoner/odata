using System.Linq;
using System.Web.OData;
using NetOData.Models;

namespace NetOData.Controllers
{
    public class SurveyVoteController : ODataController
    {
        MySampleDb _context = new MySampleDb();

        [EnableQuery]
        public IQueryable<SurveyVote> Get()
        {
            return _context.SurveyVotes;
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
