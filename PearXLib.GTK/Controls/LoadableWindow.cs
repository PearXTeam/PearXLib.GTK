using System.Linq;
using Gtk;

namespace PearXLib.GTK.Controls
{
	public class LoadableWindow : PXWindow
	{
		public Overlay Overlay = new Overlay();
		public Frame Fr = new Frame();
		public Spinner Loading = null;
		public bool UseDefaultLoading { get; set; } = true;

		public LoadableWindow()
		{
			base.Add(Overlay);
		}

		public void StartLoading()
		{
			Application.Invoke((sender, e) =>
			{
				if (UseDefaultLoading && Loading == null)
				{
					Loading = new Spinner();
					Loading.Expand = false;
					Loading.Start();
				}
				Overlay.Child.Hide();
				if (!Overlay.Children.Contains(Loading))
					Overlay.AddOverlay(Loading);
				Loading.ShowAll();
			});
		}

		public void StopLoading()
		{
			Application.Invoke((sender, e) =>
			{
				Loading.Stop();
				Loading.Hide();
				Overlay.Child.Show();
			});
		}

		public new void Add(Widget w)
		{
			Overlay.Add(w);
		}


		public new void Remove(Widget w)
		{
			Overlay.Remove(w);
		}
	}
}
