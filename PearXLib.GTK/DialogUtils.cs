using Gtk;

namespace PearXLib.GTK
{
	public static class DialogUtils
	{
		public static ResponseType Message(string msg, string title, MessageType t, Window parent = null)
		{
			string stock = "";
			switch (t)
			{
				case MessageType.Info:
					stock = Stock.DialogInfo;
					break;
				case MessageType.Error:
					stock = Stock.DialogError;
					break;
				case MessageType.Warning:
					stock = Stock.DialogWarning;
					break;
				case MessageType.Question:
					stock = Stock.DialogQuestion;
					break;
			}
			DialogFlags flags = DialogFlags.Modal;
			if (parent != null)
				flags = DialogFlags.DestroyWithParent;
			ImageDialog dial = new ImageDialog(msg, parent, new Image(stock, IconSize.Dialog), flags, Stock.Ok, ResponseType.Ok);
			dial.Title = title;
			ResponseType resp = (ResponseType)dial.Run();
			dial.Destroy();
			return resp;
		}

		public static ResponseType Question(string msg, string title, Window parent = null)
		{
			DialogFlags flags = DialogFlags.Modal;
			if (parent != null)
				flags = DialogFlags.DestroyWithParent;
			ImageDialog dial = new ImageDialog(msg, parent, new Image(Stock.DialogQuestion, IconSize.Dialog), flags, Stock.Yes, ResponseType.Yes, Stock.No, ResponseType.No);
			dial.Title = title;
			ResponseType resp = (ResponseType)dial.Run();
			dial.Destroy();
			return resp;
		}
	}
}
