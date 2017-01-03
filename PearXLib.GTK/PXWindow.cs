using System;
using Gtk;

namespace PearXLib.GTK
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
			Shown += (sender, e) =>
			{
				if (Child != null)
					Child.ShowAll();
			};
			SetPosition(WindowPosition.CenterAlways);
		}
	}
}
