using System.Drawing;

namespace Reor.Illustrations.Extensions;

public static class ColourExtensions
{
    public static string ToHex(this Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}";
    }
}