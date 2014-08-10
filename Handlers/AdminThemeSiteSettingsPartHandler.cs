using JetBrains.Annotations;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;
using Orchard.Localization;
using Admin.Bootstrap.Models;

namespace Admin.Bootstrap.Handlers {
    [UsedImplicitly]
    public class AdminThemeSiteSettingsPartHandler : ContentHandler {
        public AdminThemeSiteSettingsPartHandler() {
            T = NullLocalizer.Instance;
            Filters.Add(new ActivatingFilter<AdminThemeSettingsPart>("Site"));
            Filters.Add(new TemplateFilterForPart<AdminThemeSettingsPart>("AdminThemeSettings", "Parts/Theme.AdminThemeSettings", "admin theme"));
        }

        public Localizer T { get; set; }

        protected override void GetItemMetadata(GetContentItemMetadataContext context) {
            if (context.ContentItem.ContentType != "Site")
                return;
            base.GetItemMetadata(context);
            context.Metadata.EditorGroupInfo.Add(new GroupInfo(T("Admin Theme")));
        }
    }
}