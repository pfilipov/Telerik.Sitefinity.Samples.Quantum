using System;
using System.Web;
using System.Web.Helpers;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Routing;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Services;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Temporary workaround due to issue: https://feedback.progress.com/Project/153/feedback/Details/263075-this-operation-requires-iis-integrated-pipeline-mode-error-when-using-antiforgery
            // that affects the Live Chat screen in Administration
            AntiForgeryConfig.SuppressXFrameOptionsHeader = true;
        }
    }
}
