# Roguelikegame
유니티사의 튜토리얼을 이용한 2D 로그라이크 게임

게임 소개
---
#### <간단한 스토리>
자신의 실력을 단련하기 위해 몬스터가 있는 타워를 오르는 용사! <br/>
세간에는 타워를 많이 오르는 것뿐만이아니라 얼마나 많은 몬스터를 잡고 왔느냐도 중요하게 여기는 듯 하다.<br/>
모험에서의 식사는 곧 체력, 타워 내에서도 식량을 얻을 수 있으니 많이 쟁여두도록 하자.<br/><br/>
![image](https://user-images.githubusercontent.com/77041622/176824671-5c557611-75ea-4d1e-8a57-f4e870a105ba.png)
<br/>본 프로젝트는 유니티에서 제공하는 **2D Roguelike** 튜토리얼을 참조 및 인용하여 제작했습니다.<br/>
https://assetstore.unity.com/packages/templates/tutorials/2d-roguelike-29825

게임 목적 및 대상
---
게임의 목적은 몇 층의 스테이지를 깼으며, 얼만큼의 점수를 얻었는지이다.<br/>
단순히 스테이지를 많이 오른 것이 좋은게 아니라 높은 점수를 얻으며, 많은 스테이지를 깨는 것이 게임의 목적이다.
<br/><br/>
게임을 플레이하는 대상은 하나의 게임을 클리어 하기 위해 많은 시간을 투자하지 못하는 사람들을 위해서 간단히 즐길 수 있지만 게임을 하는 느낌을 얻고자 하는 사람이 대상이다.
<br/>간단히 말하면 짬짬히 가벼운 게임을 하고 싶어하는 사람들이 주 대상이다.

스크립트 관련
---
맵 생성 및 프리팹 랜덤 배치, 사운드 관련 코드를 유니티에서 제공하는 튜토리얼에서 사용했습니다.<br/>
나머지 기능들은 부분 인용 및 직접 제작하였습니다.<br/>

#### <플레이어가 적군을 공격시 스크립트><br/>
![image](https://user-images.githubusercontent.com/77041622/176826499-fb09d405-0ce6-4dd3-a022-f35d206491cd.png)
<br/>몬스터의 체력과 점수는 public 변수를 이용하여 인스펙터 창에서도 몬스터 종류별로 조정할 수 있게 하였습니다.<br/>
맞을 때마다 공격 사운드 2개 중 하나가 랜덤하게 나오도록하고, 몬스터를 공격할 시 몬스터는 플레이어 공격력 만큼 체력이 빠집니다.<br/>
체력이 0이 되면 사라지고, 카운터에 몬스터의 점수만큼 더해줍니다.<br/><br/>

#### <몬스터가 플레이어를 따라가도록 하는 스크립트><br/>
![image](https://user-images.githubusercontent.com/77041622/176826974-01b019f3-310a-45ee-b6f1-966f74e4c00d.png)
<br/>기존 코드를 어느정도 인용한 스크립트입니다.<br/>
타겟(플레이어)와 몬스터의 x좌표와 y좌표를 따로 계산을 합니다.<br/>
타겟의 좌표가 몬스터의 좌표보다 크면 값이 1이 되어 좌표상 +1만큼 이동, 작으면 값이 -1이 되어 좌표상 -1만큼 이동합니다.<br/>
leftFlag를 이용하여 좌, 우 이동시 모습이 대칭되도록 하였습니다.<br/><br/>

#### <Esc버튼을 누를 시 서브 메뉴 호출 하는 스크립트><br/>
![image](https://user-images.githubusercontent.com/77041622/176827147-022b06bf-6b72-4f90-b24c-0635d94a82f2.png)
<br/>인스펙터에서 메뉴셋(서브 메뉴 화면을 담고있는 이미지)를 할당할 수 있게 public으로 선언했습니다.<br/>
ESC버튼을 눌렀을 때 서브메뉴가 켜져있다면 서브메뉴를 닫고, 서브메뉴가 켜져있지 않다면  서브메뉴를 SetActive시켜 활성화 했습니다.<br/><br/>

사용한 에셋
---
#### <배경 UI 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176827446-fb81b49b-270b-4180-8105-872d04c8422f.png)
<br/>2D Roguelike(https://assetstore.unity.com/packages/templates/tutorials/2d-roguelike-29825)<br/>

#### <플레이어 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176827777-1c56f0a3-9acb-4c3f-995a-97052e363d06.png)
<br/>Hero Knight(https://assetstore.unity.com/packages/2d/characters/hero-knight-167779)<br/>

#### <몬스터 관련 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176827886-2e0ff391-92ce-4656-971a-bd01180b4989.png)
<br/>Enemy Galore 1-Pixel Art(https://assetstore.unity.com/packages/2d/characters/enemy-galore-1-pixel-art-208921)<br/>

#### <음식 관련 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176828051-afb7ff81-2640-46c9-94c6-581f643353c7.png)
<br/>Free Pixel Food(https://assetstore.unity.com/packages/2d/environments/free-pixel-food-113523)<br/>

#### <메뉴 UI 관련 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176828170-63a242ae-cf98-46f3-a611-764d6d1ac5aa.png)
<br/>Dark Theme UI(https://assetstore.unity.com/packages/2d/gui/dark-theme-ui-199010)<br/>

#### <사운드 관련 에셋><br/>
![image](https://user-images.githubusercontent.com/77041622/176828253-0d24a98e-b555-45c9-a974-3344634ace09.png)
<br/>Swrod Sound Pack(https://assetstore.unity.com/packages/audio/sound-fx/weapons/swordsoundpack-177824)<br/>
