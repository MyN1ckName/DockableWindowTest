using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;

namespace DockableWindowTest
{
	[TransactionAttribute(TransactionMode.Manual)]
	[RegenerationAttribute(RegenerationOption.Manual)]
	class Command : IExternalCommand
	{
		public Result Execute(
		  ExternalCommandData commandData,
		  ref string message,
		  ElementSet elements)
		{
			UIApplication uiapp = commandData.Application;

			if (DockablePane.PaneIsRegistered(Controls.Control1.PaneId))
			{				
				DockablePane myCustomPane =
					uiapp.GetDockablePane(Controls.Control1.PaneId);

				if (myCustomPane.IsShown())
					myCustomPane.Hide();
				else myCustomPane.Show();
			}

			else
			{
				return Result.Failed;
			}

			return Result.Succeeded;
		}
	}
}