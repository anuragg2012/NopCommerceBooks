using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Menu;
using Nop.Services.Security;
using Nop.Services.Plugins;
using Nop.Web.Framework;

public class CustomPlugin : BasePlugin, IAdminMenuPlugin
{
    private readonly IPermissionService _permissionService;

    public CustomPlugin(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    public async Task ManageSiteMapAsync(SiteMapNode rootNode)
    {
        // Check if the user has permission to view the plugin menu item
        if (!await _permissionService.AuthorizeAsync(StandardPermission.Configuration.MANAGE_PLUGINS))
            return;

        // Define your menu item
        var menuItem = new SiteMapNode
        {
            SystemName = "Books",
            Title = "Manage Books",
            ControllerName = "Books",
            ActionName = "List",
            IconClass = "far fa-dot-circle",
            Visible = true,
            RouteValues = new RouteValueDictionary() { { "area", AreaNames.ADMIN } }
        };

        // Add it to the 'Third party plugins' section or create a new section
        var pluginNode = rootNode.ChildNodes.FirstOrDefault(x => x.SystemName == "Third party plugins");
        if (pluginNode != null)
            pluginNode.ChildNodes.Add(menuItem);
        else
            rootNode.ChildNodes.Add(menuItem);
    }
}

