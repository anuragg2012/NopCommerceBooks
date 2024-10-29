using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Custom.Controllers;

[AuthorizeAdmin]
[Area(AreaNames.ADMIN)]
[AutoValidateAntiforgeryToken]
public class CustomPluginController: BasePluginController
{
    #region Fields
    #endregion

    #region Ctor
    public CustomPluginController()
    {
        
    }
    #endregion

    #region Utilities
    #endregion

    #region Methods
    public IActionResult List()
    {
        // Code for your plugin's admin page
        return View("~/Plugins/YourPluginName/Views/CustomPlugin/List.cshtml");
    }
    #endregion
}
