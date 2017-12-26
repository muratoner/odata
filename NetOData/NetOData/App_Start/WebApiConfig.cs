using System.Web.Http;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using Microsoft.OData.Edm;
using NetOData.Models;

namespace NetOData
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", "odata", GetModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config.Filter().Expand().Select().OrderBy().MaxTop(100).Count();
        }

        public static IEdmModel GetModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.ContainerName = "CustomersContext";
            builder.EntitySet<Birthday>("Birthday");
            builder.EntitySet<Category>("Category");
            builder.EntitySet<Page>("Page");
            builder.EntitySet<Photo>("Photo");
            builder.EntitySet<Announce>("Announce");
            builder.EntitySet<SurveyVote>("SurveyVote");
            builder.EntitySet<SurveyItem>("SurveyItem");
            builder.EntitySet<Survey>("Survey");
            return builder.GetEdmModel();
        }
    }
}
