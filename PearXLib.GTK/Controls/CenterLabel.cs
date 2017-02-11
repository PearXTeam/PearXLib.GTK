using Gtk;

namespace PearXLib.GTK.Controls
{
	public class CenterLabel : Label
	{
		public CenterLabel()
		{
			Halign = Align.Center;
		}

		public CenterLabel(string text) : base()
		{
			Text = text;
		}
	}
}
