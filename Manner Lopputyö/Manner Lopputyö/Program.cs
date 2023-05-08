using KnightsQuest;
using System;

class Program
{
    static void Main(string[] args)
    {
        Player player= new Player();
        Enemy enemy= new Enemy();
        int gold = 0;
        bool gameOver = false;

        Console.WriteLine("Tervetuloa peliin!");

        while (!gameOver)
        {
            Console.WriteLine("Valitse vihollinen, jonka kanssa haluat taistella:");
            Console.WriteLine("1. Goblin");
            Console.WriteLine("2. Örkki");
            Console.WriteLine("3. Lohikäärme");
            Console.WriteLine("4. Kauppa");
            Console.WriteLine("5. Lopeta peli");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    
                    while (!enemy.IsDefeated)
                    {
                        Console.WriteLine("Taistelet goblinia vastaan!");
                        Console.WriteLine($"Pelaajan hp: {player.Health}");
                        Console.WriteLine($"Goblinin hp: {enemy.Health}");
                        Console.WriteLine("");
                        Console.WriteLine("Valitse hyökkäys:");
                        Console.WriteLine("1. Lyödä miekalla");
                        Console.WriteLine("2. Käyttää loitsua");
                        Console.WriteLine("3. Käytä taikajuoma");

                        int attackChoice = int.Parse(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                int damage = 10;
                                enemy.Health -= damage;
                                Console.WriteLine("Osuit gobliniin " + damage + " vahingolla. Goblinilla on nyt jäljellä " + enemy.Health + " elämää.");
                                
                                break;
                            case 2:
                                Console.WriteLine("Et osannut loitsua ja gobliini iski sinua 5 vahingolla!");
                                break;
                            case 3:
                                {
                                    if (player.taikajuoma > 0)
                                    {
                                        Console.WriteLine("Käytät taikajuoman");
                                        player.Health += 15;
                                        player.taikajuoma--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sinulle ei ole taikajuomaa");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Virheellinen syöte.");
                                break;
                        }

                        if (enemy.IsDefeated)
                        {
                            Console.WriteLine("Voitit goblinin! Saat 10 kultaa.");
                            gold += 10;
                            Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");

                        }

                        enemy.Attack(player);
                        if(player.IsDefeated)
                        {
                            Console.WriteLine("Sinut tapettiin!");
                            continue;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Taistelet Örkkiä vastaan!");
                    
                    
                   
                    int enemyHealthö = 30;
                    while (enemyHealthö > 0)
                    {
                        Console.WriteLine($"Pelaajan hp: {player.Health}");
                        Console.WriteLine($"Örkin hp: {enemy.Healthö}");
                        Console.WriteLine("");
                        Console.WriteLine("Valitse hyökkäys:");
                        Console.WriteLine("1. Lyödä miekalla");
                        Console.WriteLine("2. Käyttää loitsua");
                        Console.WriteLine("3. Käytä taikajuoma");

                        int attackChoice = int.Parse(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                int damage = 10;
                                enemyHealthö -= damage;
                                Console.WriteLine("Osuit Örkkiin " + damage + " vahingolla. Örkillä on nyt jäljellä " + enemyHealthö + " elämää.");
                                break;
                            case 2:
                                Console.WriteLine("Et osannut loitsua ja Örkki iski sinua 5 vahingolla!");
                                
                                Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                                break;
                            case 3:
                                {
                                    if (player.taikajuoma > 0)
                                    {
                                        Console.WriteLine("Käytät taikajuoman");
                                        player.Health += 15;
                                        player.taikajuoma--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sinulle ei ole taikajuomaa");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Virheellinen syöte.");
                                break;
                        }

                        if (enemyHealthö <= 0)
                        {
                            Console.WriteLine("Voitit Örkin! Saat 15 kultaa.");
                            gold += 15;
                            Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Taistelet Lohikäärmeettä vastaan!");
                  
                   
                    int enemyHealthl = 50;
                    while (enemyHealthl > 0)
                    {
                        Console.WriteLine($"Pelaajan hp: {player.Health}");
                        Console.WriteLine($"lohikäärmeen hp: {enemy.Healthl}");
                        Console.WriteLine("");
                        Console.WriteLine("Valitse hyökkäys:");
                        Console.WriteLine("1. Lyödä miekalla");
                        Console.WriteLine("2. Käyttää loitsua");
                        Console.WriteLine("3. Käyttää taikajuoma");
                        int attackChoice = int.Parse(Console.ReadLine());

                        switch (attackChoice)
                        {
                            case 1:
                                int damage = 10;
                                enemyHealthl -= damage;
                                Console.WriteLine("Osuit Lohikäärmeeseen " + damage + " vahingolla. Lohikäärmeellä on nyt jäljellä " + enemyHealthl + " elämää.");
                                break;
                            case 2:
                                Console.WriteLine("Et osannut loitsua ja Lohikäärme poltti sinua 5 vahingolla!");
                                
                                Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                                break;
                            case 3:
                                {
                                    if (player.taikajuoma > 0)
                                    {
                                        Console.WriteLine("Käytät taikajuoman");
                                        player.Health += 15;
                                        player.taikajuoma--;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sinulle ei ole taikajuomaa");
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Virheellinen syöte.");
                                break;
                        }

                        if (enemyHealthl <= 0)
                        {
                            Console.WriteLine("Voitit lohikäärmeen! Saat 30 kultaa.");
                            gold += 30;
                            Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                        }
                    }
                    enemy.Attack(player);
                    if (player.IsDefeated)
                    {
                        Console.WriteLine("Kuolit!");
                        return;
                    }
                    break;
                case 4:
                    Console.WriteLine("Käyt kaupassa. Mitä haluat ostaa?");
                    Console.WriteLine("1. Miekka (10 kultaa)");
                    Console.WriteLine("2. Loitsu (10 kultaa)");
                    Console.WriteLine("3. Taikajuoma (10 kultaa)");
                    Console.WriteLine("4. Armor(10 kultaa)");
                    Console.WriteLine("5. Poistu.");

                    int purchaseChoice = int.Parse(Console.ReadLine());
                    if (gold < 10)
                    {
                        Console.WriteLine("Sinulla ei ole tarpeeksi kultaa tähän.");
                    }
                    else
                    {
                        switch (purchaseChoice)
                        {
                            case 1:
                                if (gold >= 10)
                                    Console.WriteLine("Ostit miekan. Se maksaa 10 kultaa.");
                                gold -= 10;
                                player.AttackDamage += 5;
                                Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                                break;
                            case 2:
                                Console.WriteLine("Ostit loitsun. Se maksaa 10 kultaa.");
                                gold -= 10;
                                Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                                break;
                            case 3:
                                Console.WriteLine("Ostit taikajuoman. Se maksaa 10 kultaa");
                                gold -= 10;
                                player.taikajuoma++;
                                Console.WriteLine("Sinulla on nyt " + gold + " kultaa.");
                                break;
                            case 4:
                                Console.WriteLine("Ostit armoria. Se maksaa 10 kultaa");
                                gold -= 10;
                                player.Health += 20;
                                break;
                            default:
                                Console.WriteLine("Virheellinen syöte.");
                                break;
                             
                        }
                        if (purchaseChoice == 5) 
                        {
                            continue;
                        }
                        
                    }
                    break;
                case 5:
                    // End the game
                    Console.WriteLine("Kiitos pelaamisesta!");
                   gameOver = false;
                    break;
            }
        }
    }
}