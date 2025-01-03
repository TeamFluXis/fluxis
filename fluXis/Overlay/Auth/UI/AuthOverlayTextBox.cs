using fluXis.Graphics.Sprites;
using fluXis.Graphics.UserInterface.Color;
using fluXis.Graphics.UserInterface.Text;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Colour;
using osu.Framework.Input.Events;

namespace fluXis.Overlay.Auth.UI;

public partial class AuthOverlayTextBox : FluXisTextBox
{
    public AuthOverlayTextBox()
    {
        RelativeSizeAxes = Axes.X;
        Height = 50;
        Anchor = Anchor.TopCentre;
        Origin = Anchor.TopCentre;
        CornerRadius = 25;
        FontSize = FluXisSpriteText.GetWebFontSize(14);
        SidePadding = 20;
        BorderThickness = 2;
        BorderColour = FluXisColors.Background4;
    }

    protected override void OnFocus(FocusEvent e)
    {
        base.OnFocus(e);
        this.TransformTo(nameof(BorderColour), (ColourInfo)FluXisColors.Highlight, 200);
    }

    protected override void OnFocusLost(FocusLostEvent e)
    {
        base.OnFocusLost(e);
        this.TransformTo(nameof(BorderColour), (ColourInfo)FluXisColors.Background4, 200);
    }
}