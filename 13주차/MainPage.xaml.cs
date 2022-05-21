using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlApp13
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //label1.Opacity = 0;
            //label1.FadeTo(1, 5000);

            //label2.Opacity = 0;
            //label2.FadeTo(1, 5000);

            //background_img.Opacity = 0;
            //background_img.FadeTo(1, 5000);
            //background_img.RotateTo(360, 5000);

            // FadeEffect();            
            MarqueeEffect(label1, label1.Width + label1.X);
        }

        private async void FadeEffect()
        {
            await label1.FadeTo(0, 1000);
            await label1.FadeTo(1, 1000);
            await label2.FadeTo(0, 1000);
            await label2.FadeTo(1, 1000);
            await background_img.FadeTo(0, 1000);
            await background_img.FadeTo(1, 1000);
            await background_img.RotateTo(360, 1000);
        }

        public static async void MarqueeEffect(Label label, double translatePosition)
        {
            await label.TranslateTo(-translatePosition, 0, 3000); // 3초동안 이동
            label.TranslationX = translatePosition;
            await label.TranslateTo(0, 0, 3000);
        }


    }
}