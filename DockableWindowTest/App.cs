using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;

namespace DockableWindowTest
{
	class App : IExternalApplication
	{
		public static Controls.Control1 MyDockablePaneControl;

		public Result OnStartup(UIControlledApplication a)
		{
			//a.ViewActivated += OnViewActivated;
			MyDockablePaneControl = new Controls.Control1()
			{
				DataContext = new Controls.Control1ViewModel(a)
			};
			
			//Controls.Control1ViewModel dockablePaneViewModel =
			//	new Controls.Control1ViewModel();
			//
			//MyDockablePaneControl.DataContext = dockablePaneViewModel;

			if (!DockablePane.PaneIsRegistered(Controls.Control1.PaneId))
			{
				a.RegisterDockablePane(Controls.Control1.PaneId,
					Controls.Control1.PaneName,
					MyDockablePaneControl);
			}

			return Result.Succeeded;
		}

		//private void OnViewActivated(object sender, ViewActivatedEventArgs e)
		//{
		//	if (e.Document == null)
		//		return;
		//
		//	var viewModel = MyDockablePaneControl.DataContext as Controls.Control1ViewModel;
		//
		//	if (viewModel != null)
		//	{
		//		viewModel.DocumentTitle = e.Document.Title;
		//	}
		//}

		public Result OnShutdown(UIControlledApplication a)
		{
			return Result.Succeeded;
		}
	}
}