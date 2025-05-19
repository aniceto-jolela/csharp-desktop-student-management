using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cpqi.ViewModels;

namespace cpqi.Views.Admin
{
    public partial class Profile : Form
    {
        private readonly CounterViewModel _viewModel;
        public Profile()
        {
            InitializeComponent();
            _viewModel = new CounterViewModel();
            lbl_Counter.DataBindings.Add(nameof(lbl_Counter.Text), _viewModel, nameof(_viewModel.Count), true, DataSourceUpdateMode.OnPropertyChanged);

            btn_increment.Command = _viewModel.IncrementCommand;
            btn_decrement.Command = _viewModel.DecrementCommand;

        }
        
    }
}
