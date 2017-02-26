using Gtk;

namespace PearXLib.GTK.Controls
{
	/// <summary>
	/// Right label.
	/// </summary>
	public class RightLabel : Label
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.RightLabel"/> class.
		/// </summary>
		public RightLabel()
		{
			Halign = Align.End;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.RightLabel"/> class.
		/// </summary>
		/// <param name="txt">Text.</param>
		public RightLabel(string txt) : base()
		{
			Halign = Align.End;
			Text = txt;
		}
	}
}
