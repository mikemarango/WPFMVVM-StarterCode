using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;
using ZzaDashboard.Services;

namespace ZzaDashboard.ViewModels
{
    public class CustomerListViewModel
    {
        private ICustomersRepository _repo = new CustomersRepository();

        public CustomerListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new System.Windows.DependencyObject()))
                return;

            Customers = new ObservableCollection<Customer>(_repo.GetCustomersAsync().Result);
        }
        public ObservableCollection<Customer> Customers { get; set; }
    }
}
