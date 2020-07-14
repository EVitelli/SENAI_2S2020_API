using App2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VeiculosView : ContentPage
    {
        VeiculosViewModel vm = new VeiculosViewModel();
        public VeiculosView()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}