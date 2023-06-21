using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GesturesSample.ViewModels
{
	public class BaseViewModel: INotifyPropertyChanged
    {
		public BaseViewModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

