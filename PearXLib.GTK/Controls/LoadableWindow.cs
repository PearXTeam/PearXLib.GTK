using Gtk;

namespace PearXLib.GTK.Controls
{
	/// <summary>
	/// Window with loading bar.
	/// </summary>
	public class LoadableWindow : PXWindow
	{
		/// <summary>
		/// Loading overlay.
		/// </summary>
		protected Overlay Overlay = new Overlay();
		/// <summary>
		/// Loading spinner
		/// </summary>
		protected Spinner Loading = new Spinner();

		bool loading = false;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.Controls.LoadableWindow"/> class.
		/// </summary>
		public LoadableWindow()
		{
			Loading.Expand = false;
			Overlay.AddOverlay(Loading);
			Loading.NoShowAll = true;
			Loading.Hide();
			base.Add(Overlay);
		}

		/// <summary>
		/// Starts the loading.
		/// </summary>
		public void StartLoading()
		{
			Application.Invoke((sender, e) =>
			{
				if (!loading)
				{
					Loading.Start();
					Overlay.Child.Hide();
					Loading.Show();
					loading = true;
				}
			});
		}

		/// <summary>
		/// Stops the loading.
		/// </summary>
		public void StopLoading()
		{
			Application.Invoke((sender, e) =>
			{
				if (loading)
				{
					Loading.Stop();
					Loading.Hide();
					Overlay.Child.Show();
					loading = false;
				}
			});
		}

		/// <summary>
		/// Add a widget to the container.
		/// </summary>
		/// <param name="w">Widget.</param>
		public new void Add(Widget w)
		{
			Overlay.Add(w);
		}

		/// <summary>
		/// Removes a widget from the container.
		/// </summary>
		/// <param name="w">Widget.</param>
		public new void Remove(Widget w)
		{
			Overlay.Remove(w);
		}
	}
}
