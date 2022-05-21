using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlApp14
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            // FadeEffect();            
            // MarqueeEffect(label1, label1.Width + label1.X);

            // SetTimer();

            //ImageAnimation();

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += labelClicked;
            label1.GestureRecognizers.Add(tapGesture);
            
        }

        // ======================================================
        //private async void FadeEffect()
        //{
        //    await label1.FadeTo(0, 1000);
        //    await label1.FadeTo(1, 1000);
        //    await label2.FadeTo(0, 1000);
        //    await label2.FadeTo(1, 1000);
        //    await background_img.FadeTo(0, 1000);
        //    await background_img.FadeTo(1, 1000);
        //    await background_img.RotateTo(360, 1000);
        //    background_img.Rotation = 0;
        //}

        //public static async void MarqueeEffect(Label label, double translatePosition)
        //{
        //    await label.TranslateTo(-translatePosition, 0, 3000, Easing.BounceIn); // 3초동안 이동
        //    label.TranslationX = translatePosition;
        //    await label.TranslateTo(0, 0, 3000, Easing.CubicIn);
        //}

        //private void SetTimer()
        //{
        //    System.Timers.Timer timer = new System.Timers.Timer();
        //    timer.Interval = 10000; // 10초
        //    timer.Enabled = true;
        //    timer.Elapsed += TimerElapsedEvent;
        //    timer.Start();
        //}

        //private void TimerElapsedEvent(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    // FadeEffect();
        //    MarqueeEffect(label1, label1.Width + label1.X);
        //}
        // ======================================================

        //private async void ImageAnimation()
        //{
        //    // 3초동안 720도 회전하고 1720 까지 이동함
        //    await Task.WhenAny<bool>(
        //        icon_image.RotateTo(720, 3000, Easing.CubicInOut),
        //        icon_image.TranslateTo(1720, 0, 3000, Easing.CubicInOut)
        //        );

        //    // 3초동안 0도로 회전하고 0까지 이동함
        //    await Task.WhenAny<bool>(
        //        icon_image.RotateTo(0, 3000, Easing.CubicInOut),
        //        icon_image.TranslateTo(0, 0, 3000, Easing.CubicInOut)
        //        );
        //}

        private void buttonClicked(object sender, EventArgs args)
        {
            Random generator = new Random();
            int r = generator.Next(0, 255);
            int g = generator.Next(0, 255);
            int b = generator.Next(0, 255);

            label1.TextColor = Color.FromRgb(r, g, b);
        }

        private void labelClicked(object sender, EventArgs args)
        {
            Random generator = new Random();
            int r = generator.Next(0, 255);
            int g = generator.Next(0, 255);
            int b = generator.Next(0, 255);

            label1.TextColor = Color.FromRgb(r, g, b);
        }

    }
}