using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.VazirFontForAdmin.Models;
using Nop.Web.Framework.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Misc.VazirFontForAdmin.Components
{
    [ViewComponent(Name = "WidgetsVazirFontForAdmin")]
    public class WidgetsVazirFontForAdminViewComponent : NopViewComponent
    {
        #region Methods

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var model = new PublicInfoModel()
            {
                DisplayText = "AmirHossein Marjani"
            };
            return View("~/Plugins/Widgets.VazirFontForAdmin/Views/PublicInfo.cshtml", model);
        }

        #endregion
    }
}
