using Gtk;

namespace PearXLib.GTK
{
	/// <summary>
	/// Dialog utilities.
	/// </summary>
	public static class DialogUtils
	{
		/// <summary>
		/// Shows a dialog with an image.
		/// </summary>
		/// <returns>Dialog response.</returns>
		/// <param name="msg">Message text.</param>
		/// <param name="title">Title text.</param>
		/// <param name="t">Message type.</param>
		/// <param name="button_data">Button data (Text, ReponseType).</param>
		/// <param name="parent">Window parent.</param>
		public static ResponseType ShowDialog(string msg, string title, MessageType t, object[] button_data, Window parent = null)
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
			ImageDialog dial = new ImageDialog(msg, parent, new Image(stock, IconSize.Dialog), flags, button_data);
			dial.Title = title;
			ResponseType resp = (ResponseType)dial.Run();
			dial.Destroy();
			return resp;
		}

		/// <summary>
		/// Shows a message dialog.
		/// </summary>
		/// <returns>Dialog response.</returns>
		/// <param name="msg">Message text.</param>
		/// <param name="title">Title text.</param>
		/// <param name="t">Message type.</param>
		/// <param name="parent">Parent window.</param>
		public static ResponseType Message(string msg, string title, MessageType t, Window parent = null)
		{
			return ShowDialog(msg, title, t, new object[] { Stock.Ok, ResponseType.Ok }, parent);
		}

		/// <summary>
		/// Shows a question dialog.
		/// </summary>
		/// <returns>Dialog response.</returns>
		/// <param name="msg">Message text.</param>
		/// <param name="title">Title text.</param>
		/// <param name="parent">Parent window.</param>
		public static ResponseType Question(string msg, string title, Window parent = null)
		{
			return ShowDialog(msg, title, MessageType.Question, new object[] { Stock.Yes, ResponseType.Yes, Stock.No, ResponseType.No }, parent);
		}
	}
}
