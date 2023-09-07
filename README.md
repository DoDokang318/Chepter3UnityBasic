# Chepter3UnityBasic
유니티 기초주차 숙제 입니다 
<h1>  구현한기능</h1> <br>
1.필수요구사항<br>
2.캐릭터 애니메이션 추가<br>
3.이름 입력 시스템<br>
4.참석 인원 UI <br>
5.시간 표시<br>
6.NPC 대화<br>
7.인게임 이름 바꾸기<br>


<h1> 클래스설명  </h1>
Character :Npc및 플레이어의 이름을 지정해주기위한클래스입니다 <br>
PlayerFallowCamera :플레이어를따라다니는 클래스입니다   lerp함수 를이용해 조금더 부드럽개 따라다닙니다 <br>
TalkBoxColison : TalkboxCollision 오브젝트 영역에 들어가면  대화창이 뜨고 나가면 사라지는 기능을 만들어준 클래스입니다 <br>
GameManager : 이곳에서 각종UI를 및 케릭터 이름 입력에 관한기능이있습니다 <br>
NumberOfAttendees: 사이드바에있는 참가자 목록을 출력해주는 클래스입니다 .<br>

<h1> 현재 있는버그   </h1>
게임 에서 플레이어 이름입력후 
다시 이름을 바꿔주면 참석인원이 갱신이되지않고 중복으로 출력되는버그 
