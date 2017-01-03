using System.Linq;
using Gtk;

namespace PearXLib.GTK
{
	public class LoadableWindow : PXWindow
	{
		public Overlay Overlay = new Overlay();
		public Widget Loading = null;
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
					Loading = new Image(new Gdk.PixbufAnimation(ResourceUtils.StreamFromResources("PearXLib.GTK.Resources.Loading.gif")));
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
				Loading.Hide();
				Overlay.Child.ShowAll();
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
