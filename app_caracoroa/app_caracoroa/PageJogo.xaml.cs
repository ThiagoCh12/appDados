using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCaraCoroa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageJogo : ContentPage
    {
        public PageJogo()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 6);
            switch(n)
            {
                case 1:
                    imgDado.Source = "dado1.png";
                    break;
                case 2:
                    imgDado.Source = "dado2.png";
                    break;
                case 3:
                    imgDado.Source = "dado3.png";
                    break;
                case 4:
                    imgDado.Source = "dado4.png";
                    break;
                case 5:
                    imgDado.Source = "dado5.png";
                    break;
                case 6:
                    imgDado.Source = "dado6.png";
                    break;


            }
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}