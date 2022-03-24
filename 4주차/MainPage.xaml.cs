using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //==============StackLayout===========================
            //var layout = new StackLayout(); // 스택 레이아웃 객체 생성
            //var label1 = new Label{ // 레이블 객체를 쓰는데 속성을 넣음
            //    Text = "Hello World!",
            //    TextColor = Color.Red,
            //    FontSize = 200,
            //    HorizontalOptions = LayoutOptions.StartAndExpand,
            //    VerticalOptions = LayoutOptions.StartAndExpand
            //};

            //var label2 = new Label
            //{ // 레이블 객체를 쓰는데 속성을 넣음
            //    Text = "Hello World!",
            //    TextColor = Color.Blue,
            //    FontSize = 200,
            //    HorizontalOptions = LayoutOptions.CenterAndExpand,
            //    VerticalOptions = LayoutOptions.CenterAndExpand
            //};

            //var label3 = new Label
            //{ // 레이블 객체를 쓰는데 속성을 넣음
            //    Text = "Hello World!",
            //    TextColor = Color.Green,
            //    FontSize = 200,
            //    HorizontalOptions = LayoutOptions.EndAndExpand,
            //    VerticalOptions = LayoutOptions.EndAndExpand
            //};

            //layout.Children.Add(label1);
            //layout.Children.Add(label2);
            //layout.Children.Add(label3);

            //Content = layout;
            //==============StackLayout===========================

            var layout = new AbsoluteLayout();

            var label1 = new Label
            {
                Text = "Hello world!",
                TextColor = Color.Red,
                FontSize = 200
            };
            AbsoluteLayout.SetLayoutBounds(label1, new Rectangle(0, 0, 600, 200));

            var label2 = new Label
            {
                Text = "Hello world!",
                TextColor = Color.Blue,
                FontSize = 200
            };
            AbsoluteLayout.SetLayoutBounds(label2, new Rectangle(700, 450, 600, 200));

            var label3 = new Label
            {
                Text = "Hello world!",
                TextColor = Color.Green,
                FontSize = 200
            };
            AbsoluteLayout.SetLayoutBounds(label3, new Rectangle(1320, 880, 600, 200));

            layout.Children.Add(label1);
            layout.Children.Add(label2);
            layout.Children.Add(label3);

            Content = layout;
        }
    }
}