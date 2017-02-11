using Gtk;

namespace PearXLib.GTK
{
	/// <summary>
	/// Random GTK extensions.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Applies the style to a widget.
		/// </summary>
		/// <param name="w">Widget.</param>
		/// <param name="prov">Style provider.</param>
		/// <param name="prior">Priority.</param>
		public static void ApplyStyle(this Widget w, IStyleProvider prov, uint prior = 500)
		{
			w.StyleContext.AddProvider(prov, prior);
			var cont = w as Container;
			if (cont == null)
				return;
			foreach (var child in cont.Children)
			{
				child.ApplyStyle(prov, prior);
			}
		}

		/// <summary>
		/// Applies the  css style to a widget.
		/// </summary>
		/// <param name="w">Widget.</param>
		/// <param name="css">Css style text.</param>
		/// <param name="prior">Priority.</param>
		public static void ApplyCss(this Widget w, string css, uint prior = 500)
		{
			CssProvider prov = new CssProvider();
			prov.LoadFromData(css);
			w.ApplyStyle(prov, prior);
		}
	}
}
