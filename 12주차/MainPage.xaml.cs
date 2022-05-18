using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// 액자만들기
namespace TizenXamlApp12
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();

            var wall = new Image
            {
                Source = "wall.jpg"
            };

            var box1 = new BoxView
            {
                Color = Color.Black
            };

            var image1 = new Image
            {
                Source = "image1.jpg",
                Aspect = Aspect.AspectFill
            };

            AbsoluteLayout.SetLayoutBounds(wall, new Rectangle(0, 0, 1920, 1080));
            AbsoluteLayout.SetLayoutBounds(box1, new Rectangle(70, 70, 660, 660));
            AbsoluteLayout.SetLayoutBounds(image1, new Rectangle(100, 100, 600, 600));

            layout.Children.Add(wall);
            layout.Children.Add(box1);
            layout.Children.Add(image1);

            Content = layout;
        }
    }
}

//// 이미지 사용법 (AbsoluteLayout)
//namespace TizenXamlApp12
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();

//            var layout = new AbsoluteLayout();

//            var image1 = new Image
//            {
//                Source = "icon.png",
//            };

//            var image2 = new Image
//            {
//                Source = "icon.png",
//            };

//            var image3 = new Image
//            {
//                Source = "icon.png",
//            };

//            AbsoluteLayout.SetLayoutBounds(image1, new Rectangle(0, 0, 100, 100));
//            AbsoluteLayout.SetLayoutBounds(image2, new Rectangle(860, 440, 200, 200));
//            AbsoluteLayout.SetLayoutBounds(image3, new Rectangle(1620, 780, 300, 300));

//            layout.Children.Add(image1);
//            layout.Children.Add(image2);
//            layout.Children.Add(image3);

//            Content = layout;
//        }
//    }
//}

// 이미지 사용법 (StackLayout)
//namespace TizenXamlApp12
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();

//            var layout = new StackLayout();

//            var image1 = new Image
//            {
//                Source = "icon.png",
//                WidthRequest = 100,
//                HeightRequest = 100,
//                HorizontalOptions = LayoutOptions.StartAndExpand,
//                VerticalOptions = LayoutOptions.StartAndExpand
//            };

//            var image2 = new Image
//            {
//                Source = "icon.png",
//                WidthRequest = 100,
//                HeightRequest = 100,
//                HorizontalOptions = LayoutOptions.CenterAndExpand,
//                VerticalOptions = LayoutOptions.CenterAndExpand
//            };

//            var image3 = new Image
//            {
//                Source = "icon.png",
//                WidthRequest = 100,
//                HeightRequest = 100,
//                HorizontalOptions = LayoutOptions.EndAndExpand,
//                VerticalOptions = LayoutOptions.EndAndExpand
//            };

//            layout.Children.Add(image1);
//            layout.Children.Add(image2);
//            layout.Children.Add(image3);

//            Content = layout;
//        }
//    }
//}


// absolute layout 사용법
//namespace TizenXamlApp12
//{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
//    public partial class MainPage : ContentPage
//    {
//        public MainPage()
//        {
//            InitializeComponent();

//            var layout = new AbsoluteLayout();

//            var label1 = new Label
//            {
//                Text = "Hello World!",
//                TextColor = Color.Blue,
//                FontSize = 100,
//            };

//            var label2 = new Label
//            {
//                Text = "Hello World!",
//                TextColor = Color.Red,
//                FontSize = 100,
//            };

//            var label3 = new Label
//            {
//                Text = "Hello World!",
//                TextColor = Color.Yellow,
//                FontSize = 100,
//            };

//            AbsoluteLayout.SetLayoutBounds(label1, new Rectangle(0, 0, 600, 200));
//            AbsoluteLayout.SetLayoutBounds(label2, new Rectangle(700, 450, 600, 200));
//            AbsoluteLayout.SetLayoutBounds(label3, new Rectangle(1320, 880, 600, 200));

//            layout.Children.Add(label1);
//            layout.Children.Add(label2);
//            layout.Children.Add(label3);

//            Content = layout;

//        }
//    }
//}