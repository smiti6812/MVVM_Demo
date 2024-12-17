using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MVVM_Demo.Services;

namespace MVVM_Demo.ViewModel
{
    public class AddEditCutomerViewModel : BindableBase
    {
        private ICustomerRepository customerRepository;

        public MyICommand CancelCommand { get; set; }
        public MyICommand SaveCommand { get; set; }
        public AddEditCutomerViewModel(ICustomerRepository custRepo)
        {
            customerRepository = custRepo;
            CancelCommand = new MyICommand(OnCancel);
            SaveCommand = new MyICommand(OnSave, CanSave);
        }
        private bool CanSave() => throw new NotImplementedException();
        private void OnSave() => throw new NotImplementedException();
        private void OnCancel() => throw new NotImplementedException();
    }
}
