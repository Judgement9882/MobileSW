using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlAppFinalProjectVideo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    
    public partial class MainPage : ContentPage
    {

        int background_index = 0;

        int weather_index = 0;
        string[] city = { "인천 날씨", "서울 날씨", "강릉 날씨", "대전 날씨", "대구 날씨", "울산 날씨", "부산 날씨", "광주 날씨", "여수 날씨", "제주 날씨" };
        string[] weather = { "맑음", "흐림", "비", "강풍", "흐림", "소나기", "맑음", "낙뢰", "맑음", "흐림" };
        int[] temperature = { 19, 25, 8, 7, 33, 28, 25, 27, 25, 25 };
        int[] dust = { 115, 24, 44, 26, 90, 37, 43, 21, 36, 15 };

        int news_index = 0;
        string[] newsline = { "우크라이나 전쟁 3개월 '정체 국면'... 러시아군 1만5천 명 사망", "전국 경유값 리터당 2천원 코앞", "여경 팔굽혀펴기 '정자세' 시험 기준 엄격", "법무부, 장관 직속 '공직자 인사검증'", "KT, 메가존과 클라우드 컨택센터 사업추진 협력", "쿼드 정상회의 시작…중국 견제·경제 협력 주목", "SKT, 양자암호통신 기술 국제 표준 채택", "비트코인 약보합세...3700만원" };

        int coin_index = 0;
        string[] coin = { "비트코인", "이더리움", "리플" };

        public MainPage()
        {
            InitializeComponent();

            string[] background_list = LoadBackgroundImage();

            UI_weather.Text = weather[this.weather_index];
            UI_city.Text = city[this.weather_index];
            UI_temperature.Text = Convert.ToString(temperature[this.weather_index] + "℃");
            UI_dust_condition.Text = Convert.ToString(dust[this.weather_index]);
            WeatherTextColorIcon();

            StartNews();

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += imageClicked;
            coin_image.GestureRecognizers.Add(tapGesture);

            CoinStatus();

            StartTimer(background_list);
        }

        // 배경 이미지를 불러오는 메소드
        private string[] LoadBackgroundImage()
        {
            string[] images = new string[4];
            for (int i = 0; i < 4; i++) images[i] = "background_image" + i.ToString() + ".jpg";
            return images;
        }

        // 현재 시간을 반환하는 메소드
        private void RealTime(DateTime Time)
        {
            hour.Text = string.Format("{0:00}", (Time.Hour) % 24);
            minute.Text = string.Format("{0:00}", (Time.Minute));
            second.Text = string.Format("{0:00}", (Time.Second));
        }

        // 특정 시간이 되면 디지털 시계를 돌리는 메소드
        private async void RotateTime(DateTime Time)
        {
            // 한시간이 지날 때 마다
            if (Time.Minute == 0 && Time.Second == 0)
            {
                await hour.RotateTo(360, 1000);
                hour.Rotation = 0;
            }
            // 5분마다 회전
            if ((Time.Minute % 5) == 0 && Time.Second == 0)
            {
                await minute.RotateTo(360, 1000);
                minute.Rotation = 0;

            }
            // 10초마다 회전
            if (Time.Second % 10 == 0)
            {
                await second.RotateTo(360, 1000);
                second.Rotation = 0;
            }
        }
        private async void StartTimer(string[] images)
        {
            RealTime(DateTime.Now);
            RotateTime(DateTime.Now);
            await Task.Delay(1000); // 1초 딜레이

            while (true)
            {
                var currentTime = DateTime.Now;
                SecEffect();
                RealTime(currentTime);
                RotateTime(currentTime);

                if (currentTime.Second >= 57) second.TextColor = Color.Red;
                else if (currentTime.Second < 57) second.TextColor = Color.White;

                // 날짜 최신화
                date.Text = string.Format(currentTime.Year + "년 " + currentTime.Month + "월 " + currentTime.Day + "일 " + currentTime.DayOfWeek);

                if (currentTime.Second % 10 == 0)
                {
                    ChangeBackgroundImage(images);
                    TranslateDate();
                    ChangeWeather();
                }
                AnalogClockStart(currentTime);

                await Task.Delay(1000); // 1초 딜레이
            }
        }
        private async void SecEffect()
        {
            second.TranslationY = -20;
            await second.TranslateTo(0, -80, 1000);
            second.Opacity = 1;
            await second.FadeTo(0, 1000);
        }

        // 배경이미지를 바꾸는 메소드
        private async void ChangeBackgroundImage(string[] images)
        {
            this.background_index = (this.background_index + 1) % 4;
            await background_image.FadeTo(0, 900);
            background_image.Source = images[background_index];
            await background_image.FadeTo(1, 900);
        }

        // 년월일 움직이기
        private async void TranslateDate()
        {
            var dateCurX = date.X + date.Width;
            await date.TranslateTo(-dateCurX, 0, 1500, Easing.Linear);
            date.TranslationX = dateCurX;
            await date.TranslateTo(0, 0, 1500, Easing.Linear);
        }

        //아날로그 시계 Start
        private async void AnalogClockStart(DateTime Time)
        {
            analog_second.RotateTo((Time.Second * 6) % 360 + 180, 0);
            analog_minute.RotateTo((Time.Minute * 6 + Time.Second * 0.1) % 360 + 180, 0);
            analog_hour.RotateTo(((Time.Hour % 12) * 30 + Time.Minute * 0.5 + Time.Second * 0.5 / 60) + 180, 0);
        }

        // 날씨의 색깔과 아이콘을 바꾸는 메소드
        private void WeatherTextColorIcon()
        {
            // 온도에 따라 색깔을 다르게 출력
            if (temperature[this.weather_index] >= 30) UI_temperature.TextColor = Color.Red;
            else if (temperature[this.weather_index] <= 10) UI_temperature.TextColor = Color.LightBlue;
            else UI_temperature.TextColor = Color.LightGreen;

            // 미세먼지에 따라 색깔을 다르게 출력
            if (dust[this.weather_index] >= 70) UI_dust_condition.TextColor = Color.Red;
            else if (dust[this.weather_index] <= 30) UI_dust_condition.TextColor = Color.LightBlue;
            else UI_dust_condition.TextColor = Color.LightGreen;

            // 날씨의 유형에 따라 다른 이미지를 출력
            if (weather[this.weather_index] == "맑음") weather_icon.Source = "sunny.png";
            else if (weather[this.weather_index] == "흐림") weather_icon.Source = "cloudy.png";
            else if (weather[this.weather_index] == "비") weather_icon.Source = "rain.png";
            else if (weather[this.weather_index] == "소나기") weather_icon.Source = "sonagi.png";
            else if (weather[this.weather_index] == "강풍") weather_icon.Source = "strong_wind.png";
            else if (weather[this.weather_index] == "낙뢰") weather_icon.Source = "thunder.png";
        }

        private async void ChangeWeather()
        {
            // weather_index 중가
            this.weather_index = (this.weather_index + 1) % 10;

            // 기존 내용 fade out
            UI_weather.FadeTo(0, 100);
            UI_city.FadeTo(0, 100);
            UI_temperature.FadeTo(0, 100);
            UI_dust_condition.FadeTo(0, 100);

            await Task.Delay(100);

            // update
            UI_weather.Text = weather[this.weather_index];
            UI_city.Text = city[this.weather_index];
            UI_temperature.Text = Convert.ToString(temperature[this.weather_index] + "℃");
            UI_dust_condition.Text = Convert.ToString(dust[this.weather_index]);
            WeatherTextColorIcon();

            // 신규 내용 fade in
            await UI_weather.FadeTo(1, 900);
            await UI_city.FadeTo(1, 900);
            await UI_temperature.FadeTo(1, 900);
            await UI_dust_condition.FadeTo(1, 900);
        }
        private async void StartNews()
        {
            news_line.Text = this.newsline[this.news_index];
            while (true)
            {
                news_line.TranslationX = 1920;
                await news_line.TranslateTo(-1920, 0, 7000, Easing.Linear);
                this.news_index = (this.news_index + 1) % 8;
                await Task.Delay(100);
                news_line.Text = this.newsline[this.news_index];
            }
        }
        private void imageClicked(object sender, EventArgs args)
        {
            this.coin_index = (this.coin_index + 1) % 3;
            CoinStatus();
        }

        private void CoinStatus()
        {
            if (this.coin_index == 0)
            {
                coin_image.Source = "ethereum.png";
                coin_value.Text = "2,529,000 KRW";
                coin_value.TextColor = Color.Blue;
                coin_name.Text = "이더리움";
                compare_to_yesterday.Text = "-2.77%";
                compare_to_yesterday.TextColor = Color.Blue;

            }
            else if (this.coin_index == 1)
            {
                coin_image.Source = "ripple.png";
                coin_value.Text = "525.30 \nKRW";
                coin_value.TextColor = Color.Blue;
                coin_name.Text = "리플";
                compare_to_yesterday.Text = "-2.45%";
                compare_to_yesterday.TextColor = Color.Blue;
            }
            else if (this.coin_index == 2)
            {
                coin_image.Source = "bitcoin.png";
                coin_value.Text = "37,094,765 KRW";
                coin_value.TextColor = Color.Red;
                coin_name.Text = "비트코인";
                compare_to_yesterday.Text = "+1.28%";
                compare_to_yesterday.TextColor = Color.Red;
            }
        }
    }
}