using MudBlazor;

namespace AppBuilder.Themes;

public static class AppTheme
{
    private static readonly string[] Rubik = ["Rubik", "sans-serif"];

    public static readonly MudTheme Light = new()
    {
        Typography = new Typography
        {
            Default = new DefaultTypography { FontFamily = Rubik },
            H1 = new H1Typography { FontFamily = Rubik },
            H2 = new H2Typography { FontFamily = Rubik },
            H3 = new H3Typography { FontFamily = Rubik },
            H4 = new H4Typography { FontFamily = Rubik },
            H5 = new H5Typography { FontFamily = Rubik },
            H6 = new H6Typography { FontFamily = Rubik },
            Body1 = new Body1Typography { FontFamily = Rubik },
            Body2 = new Body2Typography{FontFamily = Rubik},
            Button = new ButtonTypography { FontFamily = Rubik }
        },
        PaletteLight = new PaletteLight
        {
            Primary = "#5B6EF5",
            Success = "#5B6EF5",
            Secondary = "#F4B400",
            Tertiary = "#5B6EF5",
            AppbarBackground = "#FFFFFF",
            AppbarText = "#111827",
            Background = "#FFF",
            Surface = "#FFFFFF",
            TextPrimary = "#3C3B45",
            TextSecondary = "#6B7280",
            Info = "#0a0e1a",
            DrawerBackground = "#FFFFFF"

        }
    };

    public static readonly MudTheme Dark = new()
    {
        Typography = new Typography
        {
            Default = new DefaultTypography { FontFamily = Rubik },
            H1 = new H1Typography { FontFamily = Rubik },
            H2 = new H2Typography { FontFamily = Rubik },
            H3 = new H3Typography { FontFamily = Rubik },
            H4 = new H4Typography { FontFamily = Rubik },
            H5 = new H5Typography { FontFamily = Rubik },
            H6 = new H6Typography { FontFamily = Rubik },
            Body1 = new Body1Typography { FontFamily = Rubik },
            Body2 = new Body2Typography { FontFamily = Rubik },
            Button = new ButtonTypography { FontFamily = Rubik }
        },
        PaletteDark = new PaletteDark
        {
            Primary = "#FFF",
            Secondary = "#FFD54F",
            Tertiary = "#5467E8",
            AppbarBackground = "#5B6EF5",
            AppbarText = "#FFFFFF",
            Background = "#1A1A24",
            Surface = "#1B1F2A",
            Success = "#5B6EF5",
            Info = "#fff",
            DrawerBackground = "#0E1126"

        }
    };
}