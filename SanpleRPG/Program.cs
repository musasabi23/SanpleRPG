using SanpleRPG;
//list4-2
//player1のインスタンスを作り、名前と体力を代入
Player player1 = new Player();
player1.name = "たかし";
player1.hp = 100;

//プレイヤー2のインスタンスを作り、名前と体力を代入
Player player2 = new Player();
player2.name = "ひろし";
player2.hp = 50;

player1.Attack();// player1が攻撃する
player2.Defense();//player2が防御する

