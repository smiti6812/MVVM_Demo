using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo.ViewModel
{
    public class MainWindowViewModel :BindableBase
    {
        public MyCommand<string> NavCommand { get; private set; }
        private BindableBase _CurrentViewModel;
        private CustomerViewModel custListViewModel;
        private OrderViewModel orderViewModelModel;
        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }
        public MainWindowViewModel()
        {
            NavCommand = new MyCommand<string>(OnNav);
            custListViewModel = new CustomerViewModel();
            orderViewModelModel = new OrderViewModel();
        }
        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "orders":
                    CurrentViewModel = orderViewModelModel;
                    break;
                case "customers":
                default:
                    CurrentViewModel = custListViewModel;
                    break;
            }
        }
    }
}
