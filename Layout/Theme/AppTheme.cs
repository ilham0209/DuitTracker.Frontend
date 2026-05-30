using MudBlazor;

namespace DuitTracker.Frontend.Layout.Theme;

public static class AppTheme
{
    public static MudTheme Create()
    {
        return new MudTheme
        {
            PaletteLight = new PaletteLight
            {
                Primary = "#2E7D32",
                PrimaryContrastText = "#FFFFFF",
                Secondary = "#1565C0",
                SecondaryContrastText = "#FFFFFF",
                Tertiary = "#F57F17",
                Background = "#F5F5F5",
                Surface = "#FFFFFF",
                AppbarBackground = "#FFFFFF",
                AppbarText = "#1A1A2E",
                DrawerBackground = "#1A1A2E",
                DrawerText = "#E0E0E0",
                DrawerIcon = "#A0A0B0",
                TextPrimary = "#1A1A2E",
                TextSecondary = "#5A5A7A",
                ActionDefault = "#5A5A7A",
                Divider = "#E8E8F0",
                Success = "#2E7D32",
                Warning = "#F57F17",
                Error = "#C62828",
                Info = "#1565C0"
            },
            PaletteDark = new PaletteDark
            {
                Primary = "#4CAF50",
                PrimaryContrastText = "#FFFFFF",
                Secondary = "#42A5F5",
                SecondaryContrastText = "#FFFFFF",
                Tertiary = "#FFB300",
                Background = "#0F0F1A",
                Surface = "#1A1A2E",
                AppbarBackground = "#1A1A2E",
                AppbarText = "#E0E0E0",
                DrawerBackground = "#12121F",
                DrawerText = "#E0E0E0",
                DrawerIcon = "#A0A0B0",
                TextPrimary = "#E0E0E0",
                TextSecondary = "#A0A0B0",
                ActionDefault = "#A0A0B0",
                Divider = "#2A2A3E",
                Success = "#4CAF50",
                Warning = "#FFB300",
                Error = "#EF5350",
                Info = "#42A5F5"
            },
            Typography = new Typography
            {
                Default = new DefaultTypography
                {
                    FontFamily = new[] { "Plus Jakarta Sans", "sans-serif" },
                    FontSize = "0.875rem",
                    FontWeight = "400",
                    LineHeight = "1.5"
                },
                H1 = new H1Typography { FontSize = "2rem", FontWeight = "700" },
                H2 = new H2Typography { FontSize = "1.75rem", FontWeight = "700" },
                H3 = new H3Typography { FontSize = "1.5rem", FontWeight = "600" },
                H4 = new H4Typography { FontSize = "1.25rem", FontWeight = "600" },
                H5 = new H5Typography { FontSize = "1.1rem", FontWeight = "600" },
                H6 = new H6Typography { FontSize = "1rem", FontWeight = "600" },
                Button = new ButtonTypography { FontWeight = "600", TextTransform = "none" }
            },
            LayoutProperties = new LayoutProperties
            {
                DefaultBorderRadius = "10px"
            }
        };
    }
}