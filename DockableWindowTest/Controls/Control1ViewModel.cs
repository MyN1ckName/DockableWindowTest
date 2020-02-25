using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DockableWindowTest.Controls
{
	class Control1ViewModel : INotifyPropertyChanged
	{
		private string _documentTitle;
		public string DocumentTitle
		{
			get { return _documentTitle; }
			set
			{
				_documentTitle = value;
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