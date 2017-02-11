using Gtk;

namespace PearXLib.GTK
{
	public class ImageDialog : Dialog
	{
		public HBox Layout = new HBox();
		public Image Image;
		public Label Msg;

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
