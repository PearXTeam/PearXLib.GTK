using Gtk;

namespace PearXLib.GTK.Controls
{
	/// <summary>
	/// A modified window.
	/// </summary>
	public class PXWindow : Window
	{
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:PearXLib.GTK.Controls.PXWindow"/> is main window. If this window main, closing this window quits the application.
		/// </summary>
		public bool Main { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.PXWindow"/> class.
		/// </summary>
		public PXWindow() : base(WindowType.Toplevel)
		{
			DeleteEvent += (o, args) =>
			{
				if (Main)
				{
					Application.Quit();
				}
			};
			SetPosition(WindowPosition.CenterAlways);
		}

		/// <summary>
		/// Shows a window with the specified parent window.
		/// </summary>
		/// <param name="parent">Parent window.</param>
		public void Show(Window parent)
		{
			TransientFor = parent;
			Show();
		}

		/// <summary>
		/// Shows this window.
		/// </summary>
		public new void Show()
		{
			ShowAll();
		}

		/// <summary>
		/// Invokes an action in the GUI thread.
		/// </summary>
		/// <param name="ac">An action delegate</param>
		public void Invoke(System.Action ac)
		{
			Application.Invoke((s, e) => ac());
		}
	}
}
