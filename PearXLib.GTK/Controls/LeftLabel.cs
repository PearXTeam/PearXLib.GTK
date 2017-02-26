using Gtk;

namespace PearXLib.GTK.Controls
{
	/// <summary>
	/// Left label.
	/// </summary>
	public class LeftLabel : Label
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.LeftLabel"/> class.
		/// </summary>
		public LeftLabel()
		{
			Halign = Align.Start;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.LeftLabel"/> class.
		/// </summary>
		/// <param name="txt">Text.</param>
		public LeftLabel(string txt)
		{
			Halign = Align.Start;
			Text = txt;
		}
	}
}
