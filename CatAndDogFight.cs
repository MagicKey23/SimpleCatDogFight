using System;
					
public class Program
{
	public static void Main()
	{
		
		int hpCat =  100;
		int hpDog = 100;
		Random dmgPlayer = new Random();
		Random dmgEnemy = new Random();
		int minDmg = 1;
		int maxDmg = 20;
		bool catTurn = true;
		
		bool gameStop = false;

		
		Console.WriteLine("Type anything to the console to start the game");
		String StartGame = Console.ReadLine();
		if(StartGame.Equals(StartGame)){
			Console.WriteLine("Ready Bite!");
			
			do{
				gameStop = true;
				int catAttack = dmgEnemy.Next(minDmg,maxDmg);
				int dogAttack = dmgEnemy.Next(minDmg,maxDmg);
				
				if(catTurn){
					Console.WriteLine("Cat Attack with {0} damages", catAttack);
					hpDog -= catAttack;
					Console.WriteLine("HP remaining for dog {0}", hpDog);
					catTurn = false;
					if(hpDog <= 0){
						Console.WriteLine("Dog Dead");
							catTurn= true;
						}
					if(!catTurn){
						Console.WriteLine("Dog Attack with {0} damages", dogAttack);
						
						hpCat -= dogAttack;
						Console.WriteLine("HP remaining for cat {0}", hpCat);
						catTurn = true;
						if(hpCat <= 0){
						Console.WriteLine("Cat Dead");
							catTurn= false;
						}
						
					}
					if(hpDog <= 0 || hpCat <= 0){
						if(hpDog <= 0){
						Console.WriteLine("Cat Won");	
							
						}else {Console.WriteLine("Dog Won");}
						gameStop = (gameStop) ? false:true;
						
					}
					
				}
											
				
			}while(gameStop);
			
		}
					
		
				
	}	
				
}
			
		
			
			
			

		
	



/*
Game description:
Requirement
Player
Enemy
HP bar for player
HP bar for enemy
Player's Damage
Enemy's Damage
Player Text
Enemy Text
Random Damage


*/
