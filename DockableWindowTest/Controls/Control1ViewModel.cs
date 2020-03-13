using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;

//using Autodesk.Revit.UI;
//using Autodesk.Revit.UI.Events;

namespace DockableWindowTest.Controls
{
	class Control1ViewModel : INotifyPropertyChanged
	{
		UIControlledApplication a;
		public Control1ViewModel(UIControlledApplication a)
		{
			this.a = a;
			a.ViewActivated += OnViewActivated;
		}

		//private void Method()
		//{
		//	a.ViewActivated += OnViewActivated;
		//}

		private void MouseDoubleClickEvent(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Hi from Button1_Click");
		}

		private void OnViewActivated(object sender, ViewActivatedEventArgs e)
		{
			this.Document = e.Document;
			documentTitle = Document.Title;
		}

		private Document document;
		public Document Document
		{
			get { return document; }
			set
			{
				document = value;
				OnPropertyChanged("Document");
			}
		}

		private string documentTitle;
		public string DocumentTitle
		{
			get { return documentTitle; }
			set
			{
				documentTitle = value;
				OnPropertyChanged("DocumentTitle");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}