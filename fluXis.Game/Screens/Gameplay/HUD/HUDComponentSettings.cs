using System.Collections.Generic;
using osu.Framework.Graphics;
using osuTK;

namespace fluXis.Game.Screens.Gameplay.HUD;

public class HUDComponentSettings
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Anchor Anchor { get; set; } = Anchor.TopLeft;
    public Anchor Origin { get; set; } = Anchor.TopLeft;
    public bool AnchorToPlayfield { get; set; } = false;

    public Dictionary<string, object> Settings { get; set; } = new();

    public void ApplyTo(Drawable drawable)
    {
        drawable.Anchor = Anchor;
        drawable.Origin = Origin;
        drawable.Position = Position;
    }

    public T GetSetting<T>(string key, T defaultValue = default)
    {
        if (Settings.TryGetValue(key, out object value))
            return (T)value;

        return defaultValue;
    }
}
