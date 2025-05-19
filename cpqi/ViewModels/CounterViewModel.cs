using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace cpqi.ViewModels
{
    internal partial class CounterViewModel : ObservableObject
    {
        private int _count;
        public int Count {
            get => _count;
            set => SetProperty(ref _count, value);
        }
        [RelayCommand]
        private void Increment() {
            Count++;
        }
        [RelayCommand]
        private void Decrement() {
            Count--;
        }
    }
}
