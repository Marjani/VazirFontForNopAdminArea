using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Misc.VazirFontForAdmin
{
    public class VazirFontForAdminPlugin : BasePlugin, IWidgetPlugin
    {
        #region Fields
        #endregion

        #region Ctor
        #endregion

        #region Methods

        public bool HideInWidgetList => false;

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsVazirFontForAdmin";
        }

        public IList<string> GetWidgetZones()
        {
            return new List<string> { AdminWidgetZones.HeaderBefore };
        }
        #endregion
    }
}
