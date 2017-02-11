using Gtk;

namespace PearXLib.GTK.Controls
{
	public class RightLabel : Label
	{
		public RightLabel()
		{
			Halign = Align.End;
		}

		public RightLabel(string txt) : base()
		{
			Text = txt;
		}
	}
}
