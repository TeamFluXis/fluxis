using osu.Framework.Graphics.Sprites;

namespace fluXis.Game.Mods;

public class FlawlessMod : IMod
{
    public string Name => "Flawless";
    public string Acronym => "FL";
    public string Description => "Only the best will do.";
    public IconUsage Icon => FontAwesome.Solid.ThumbsUp;
    public float ScoreMultiplier => 1.0f;
    public bool Rankable => true;
    public string[] IncompatibleMods => new[] { "NF", "HD", "EZ", "AP", "FR" };
}
