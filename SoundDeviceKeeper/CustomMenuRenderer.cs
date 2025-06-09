using System.Windows.Forms;
using System.Drawing;

public class CustomMenuRenderer : ToolStripProfessionalRenderer
{
    public CustomMenuRenderer() : base(new CustomColorTable()) { }

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        // 親が MenuStrip なら（＝メニューバーの項目）
        if (e.ToolStrip is MenuStrip)
        {
            // MenuStripと同じ色（例: 31,31,31）
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(31, 31, 31)))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
            }
        }
        else
        {
            // ドロップダウン（サブメニュー）
            Color bgColor = Color.FromArgb(31, 31, 31);
            if (e.Item.Selected)
            {
                bgColor = Color.FromArgb(0, 118, 208);
            }
            using (SolidBrush brush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(Point.Empty, e.Item.Size));
            }
        }
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        e.TextColor = Color.White;
        base.OnRenderItemText(e);
    }
}

public class CustomColorTable : ProfessionalColorTable
{
    public override Color ToolStripDropDownBackground => Color.FromArgb(31, 31, 31);
    public override Color MenuItemSelected => Color.FromArgb(0, 118, 208);
    public override Color MenuItemBorder => Color.FromArgb(0, 118, 208);
    public override Color ImageMarginGradientBegin => Color.FromArgb(31, 31, 31);
    public override Color ImageMarginGradientMiddle => Color.FromArgb(31, 31, 31);
    public override Color ImageMarginGradientEnd => Color.FromArgb(31, 31, 31);
}