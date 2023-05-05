using Lombiq.Hosting.MediaTheme.Bridge.Constants;
using OrchardCore.DisplayManagement.Manifest;

[assembly: Theme(
    Name = "Geo&Dent Custom Theme",
    Author = "Máté Zsolt",
    Version = "0.0.1 alpha",
    Website = "https://github.com/Vipiti-Vapoti/Geo-Dent",
    Description = "A custom DotNest theme for Geo&Dent Kkt.",
    BaseTheme = "TheBlogTheme",
    Dependencies = new[]
    {
        FeatureNames.MediaThemeBridge
    }
)]
