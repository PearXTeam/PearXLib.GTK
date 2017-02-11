using System.Collections.Generic;
using Gtk;

namespace PearXLib.GTK
{
	public static class ModelExtensions
	{
		public static object[] GetValues(this ITreeModel model, int column = 0)
		{
			List<object> l = new List<object>();
			for (int i = 0; i < model.IterNChildren(); i++)
			{
				l.Add(model.GetValue(i, column));
			}
			return l.ToArray();
		}

		public static object GetValue(this ITreeModel model, int index, int column = 0)
		{
			var path = new TreePath(new int[] { index });
			TreeIter iter;
			model.GetIter(out iter, path);
			return model.GetValue(iter, column);
		}
	}
}
