using MaterialSkin.Controls;
using System.Drawing;

namespace NozzhaPRC.Components
{
    /// <summary>
    /// Allow changing font size that is static and not changable by the `MaterialLabel` control
    /// </summary>
    public class TextView : MaterialLabel
    {
        public TextView()
            : base()
        {
            Font = new Font(Font.FontFamily, 11);
        }

        protected override void OnCreateControl()
        {
            float fontSize = Font.Size;

            base.OnCreateControl();

            Font = new Font(Font.FontFamily, fontSize);
        }

    }
}
