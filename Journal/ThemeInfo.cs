﻿using Oqtane.Themes;

namespace Oqtane.Theme.Bootswatch.Journal
{
    public class ThemeInfo : ITheme
    {
        public Models.Theme Theme => new Models.Theme
        {
            Name = "Bootswatch Journal Theme",
            Version = "1.0.0",
            ContainerSettingsType = "Oqtane.Theme.Bootswatch.ContainerSettings, Oqtane.Theme.Bootswatch.Oqtane"
        };
    }
}