using lab14.Models;
using lab14.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab14.ViewModels
{
    public class ViewModelVestimenta : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Product> vestimenta;
        public List<Product> Vestimenta
        {
            get { return this.vestimenta; }
            set { SetValue(ref this.vestimenta, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelVestimenta()
        {

            SearchCommand = new Command(() =>
            {
                ProductService service = new ProductService();
                Vestimenta = service.GetByText(Filter);
                if (Vestimenta.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    }
}
