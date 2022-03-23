# MobileSW

## 4-1-3 Xamarin 기초

MainPage.xaml 의 ContentPage.Content 태그 내용을 다룹니다.

## 1. StackLayout

: 레이블들을 세로로 쌓는 레이아웃

- VerticalOptions와 HorizontalOptions의 Start, Center, End, StartAndExpand, CenterAndExpand, EndAndExpand 옵션을 다룹니다.


- VerticalOptions : 세로 레이블에 관한 옵션

Start -> 상
Center -> 중
End -> 하
StartAndExpand -> 상, 해당 레이블이 공백을 차지함
CenterAndExpand -> 상, 해당 레이블이 공백을 차지함
EndAndExpand -> 상, 해당 레이블이 공백을 차지함

특징 : 세로로 쌓는 레이블 특성상 AndExpand 옵션 유무에 따라 세로축 위치가 달라진다.


- HorizontalOptions : 가로 레이블에 관한 옵션

Start -> 좌
Center -> 중
End -> 우
StartAndExpand -> 좌, 해당 레이블이 공백을 차지함
CenterAndExpand -> 중, 해당 레이블이 공백을 차지함
EndAndExpand -> 우, 해당 레이블이 공백을 차지함

특징 : 세로로 쌓는 레이블 특성때문에 가로축 레이블은 AndExpand 옵션 유무와 상관없이 항상 같은 위치에 자리한다.

## 2. AbsoluteLayout

: StackLayout과 다르게 절대 좌표로 레이블의 위치를 결정함

- AbsoluteLayout.LayoutBounds="x, y, Width, Height"

x와 y는 시작 좌표
