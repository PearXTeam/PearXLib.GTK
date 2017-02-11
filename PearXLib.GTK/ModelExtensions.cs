using System.Collections.Generic;
using Gtk;

namespace PearXLib.GTK
{
	/// <summary>
	/// Model store extensions.
	/// </summary>
	public static class ModelExtensions
	{
		/// <summary>
		/// Get a column values.
		/// </summary>
		/// <returns>Values.</returns>
		/// <param name="model">Model.</param>
		/// <param name="column">Column.</param>
		public static object[] GetValues(this ITreeModel model, int column = 0)
		{
			List<object> l = new List<object>();
			for (int i = 0; i < model.IterNChildren(); i++)
			{
				l.Add(model.GetValue(i, column));
			}
			return l.ToArray();
		}

		/// <summary>
		/// Gets a value.
		/// </summary>
		/// <returns>The value.</returns>
		/// <param name="model">Model.</param>
		/// <param name="index">Index.</param>
		/// <param name="column">Column.</param>
		public static object GetValue(this ITreeModel model, int index, int column = 0)
		{
			var path = new TreePath(new int[] { index });
			TreeIter iter;
			model.GetIter(out iter, path);
			return model.GetValue(iter, column);
		}
	}
}
