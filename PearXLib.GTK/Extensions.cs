using Gtk;

namespace PearXLib.GTK
{
	public static class Extensions
	{
		public static void ApplyStyle(this Widget w, IStyleProvider prov, uint prior)
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

		public static void ApplyCss(this Widget w, string css, uint prior)
		{
			CssProvider prov = new CssProvider();
			prov.LoadFromData(css);
			w.ApplyStyle(prov, prior);
		}
	}
}
