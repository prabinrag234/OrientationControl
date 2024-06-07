using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NonRotate : ContentPage
    {
        public NonRotate()
        {
            InitializeComponent();
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}