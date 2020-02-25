using System;
using System.Windows.Controls;

using Autodesk.Revit.UI;

namespace DockableWindowTest.Controls
{
	public partial class Control1 : UserControl, IDockablePaneProvider
	{
		public Control1()
		{
			InitializeComponent();
		}
		public void SetupDockablePane(DockablePaneProviderData data)
		{
			data.FrameworkElement = this;
		}

		public static DockablePaneId PaneId
		{
			get
			{
				return new DockablePaneId(new Guid("D12C5388-69C4-4A27-B440-5AF7AF03D5F1"));
			}
		}

		public static string PaneName
		{
			get
			{
				return "Control1";
			}
		}
	}
}