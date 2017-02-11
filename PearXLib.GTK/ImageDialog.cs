using Gtk;

namespace PearXLib.GTK
{
	/// <summary>
	/// A dialog with an image.
	/// </summary>
	public class ImageDialog : Dialog
	{
		/// <summary>
		/// The layout.
		/// </summary>
		protected HBox Layout = new HBox();
		/// <summary>
		/// The image.
		/// </summary>
		protected Image Image;
		/// <summary>
		/// The message.
		/// </summary>
		protected Label Msg;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:PearXLib.GTK.ImageDialog"/> class.
		/// </summary>
		/// <param name="msg">Message text.</param>
		/// <param name="parent">Parent window.</param>
		/// <param name="img">Image.</param>
		/// <param name="flags">Dialog flags.</param>
		/// <param name="button_data">Button data (Text, ReponseType).</param>
		public ImageDialog(string msg, Window parent, Image img, DialogFlags flags, params object[] button_data) : base("", parent, flags, button_data)
		{
			Image = img;
			Msg = new Label(msg);
			Layout.PackStart(Image, false, false, 5);
			Layout.PackStart(Msg, true, true, 5);
			ContentArea.Add(Layout);
			ShowAll();
		}
	}
}
