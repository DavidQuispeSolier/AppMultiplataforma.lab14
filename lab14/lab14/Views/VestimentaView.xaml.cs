using lab14.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VestimentaView : ContentPage
    {
        public VestimentaView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelVestimenta();
        }
    }
}