using SanpleRPG;
//list4-2
//list4-4
//list4-6
Player player = new Player("ひろし", 100);

int hp = player.GetHp();
int newHP = hp - 2000;
player.SetHp(newHP);
Console.WriteLine("HPは" + player.GetHp());
