using Gtk;

namespace PearXLib.GTK.Controls
{
	/// <summary>
	/// Centered label.
	/// </summary>
	public class CenterLabel : Label
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.CenterLabel"/> class.
		/// </summary>
		public CenterLabel()
		{
			Halign = Align.Center;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.CenterLabel"/> class.
		/// </summary>
		/// <param name="text">Text.</param>
		public CenterLabel(string text) : base()
		{
			Text = text;
		}
	}
}
