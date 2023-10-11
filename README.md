# Product


<img src="https://img.shields.io/badge/.NET-0099E5?style=for-the-badge&logo=dotnet&logoColor=white">
<img src="https://img.shields.io/badge/visualstudio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white">
<img src="https://img.shields.io/badge/ADO.NET-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white">
<img src="https://img.shields.io/badge/microsoftsqlserver?style=flat&logo=microsoftsqlserver&logoColor=#CC2927">

## Product
<h2>Product</h2>
<img src=https://github.com/psk0812/Product/assets/130532081/0446b1c8-d1c9-40cb-b061-b0c754cbde4e">
일단 기본적으로 메뉴 부분은 시간이 표시되고, 네트워크 연결상태를 보여준다.
네트워크가 끊기면 에러(붉은색)으로 바뀐다.

Porduct에서는 위에 데이터피커에 따른 기간별 생산량을 볼수 있다.
일정 시간에 따라 계속 업데이트가 되기에 실시간으로 확인할 수 있다. 
종류별 그 기간동안 생산된 갯수와, 오류의 갯수가 나타나며, 이는 그래프로 확인할수 있게 했다.

옆의 체크박스로 원하는 종류만 보는 것도 가능하며, 데이터그리드 클릭시 그 행이 연보라색이 된다. (한번 더 클릭하면 돌아옴)


<h2>Report</h2>
<img src="https://github.com/psk0812/Product/assets/130532081/1d75aa0a-faa4-4ddb-93c9-489faecb3551">

첫번째 그래프는 각 날짜별 오류 코드별 불량품이 얼마나 나왔는지 볼수 있는 그래프다.
두번째 그래프는 기간에 따른 오류가 발생한 경우, 각 코드별 오류가 몇퍼센트인지 확인할수 있는 도넛 그래프이다.
세번째 그래프는 전체 생산량과 오류량을 나타낸 것이다.

<h2>Report</h2>
<img src="https://github.com/psk0812/Product/assets/130532081/6d266e5d-fcfd-4653-a850-901d8b2304fb">
ADO.NET을 통해 MVVM 패턴을 구현하였다.(data는 Northwind이다)

NEW버튼을 누르고 데이터를 입력후 Save를 하면 바로 mssql에 적용된다. 
행을 누르고 DLETE를 누른후 Save하면 mssql에서 삭제된다.





