using Orchard.UI.Resources;

namespace Admin.Bootstrap {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("Bootstrap").SetUrl("bootstrap-3.2.0/js/bootstrap.min.js", "bootstrap-3.2.0/js/bootstrap.js").SetDependencies("jQuery");
            manifest.DefineScript("HoverDropdown").SetUrl("hover-dropdown.js").SetDependencies("Bootstrap");
            manifest.DefineScript("Custom").SetUrl("custom.js").SetDependencies("jQuery");
            manifest.DefineScript("Styler").SetUrl("styler.js").SetDependencies("jQuery");
            manifest.DefineScript("ToolTip").SetUrl("bootstrap-3.2.0/js/tooltip.js").SetDependencies("Bootstrap");

        }
    }
}
