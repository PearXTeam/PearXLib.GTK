using Gtk;

namespace PearXLib.GTK.Controls
{
	public class PXWindow : Window
	{

		public bool Main { get; set; }

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

		public void Show(Window parent)
		{
			TransientFor = parent;
			Show();
		}

		public new void Show()
		{
			ShowAll();
		}

		public void Invoke(System.Action ac)
		{
			Application.Invoke((s, e) => ac());
		}
	}
}
