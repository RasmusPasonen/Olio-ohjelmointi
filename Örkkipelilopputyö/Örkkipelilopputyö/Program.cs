using System;

namespace Örkkipelilopputyö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa ritari!");

            // Player class
            Player player = new Player();

            // Enemy class
            Enemy enemy = new Enemy();

            while (true)
            {
                // Taistelun status
                Console.WriteLine();
                Console.WriteLine($"Tässä on päävalikko");
                Console.WriteLine($"Mitäs haluat tehä");

                // Kysy pelaajalta mitä hän tekee
                Console.WriteLine("Mitä aijot tehdä?");
                Console.WriteLine("1. Kauppa");
                Console.WriteLine("2. Klonkku");
                Console.WriteLine("3. Gandalf");
                Console.WriteLine("4. Sauron");
                Console.Write("Valinta: ");

                int choice = int.Parse(Console.ReadLine());

                // Players choice

                if (choice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Tämä on Kauppa");
                    Console.WriteLine($"Pelaajan Saldo: {player.Money}");
                    Console.WriteLine($"Valitse mitä haluat tehdä");

                    // Kysy pelaajalta mitä hän haluaa ostaa
                    Console.WriteLine("Mitä aiot tehdä?");
                    Console.WriteLine("1. Haarniska (5 gold) (+5 hp)");
                    Console.WriteLine("2. Kypärä (5 gold) (+5 hp)");
                    Console.WriteLine("3. Taikajuoma (5 gold) (kun käytetty +20hp)");
                    Console.WriteLine("4. Miekka +1 dmg (5 gold)");
                    Console.WriteLine("5. Takasin");
                    Console.Write("Valinta: ");
                    int valinta = int.Parse(Console.ReadLine());
                    if (player.Money < 5)
                    {
                        Console.WriteLine("Köyhä!");
                    }
                    else
                    {
                        if (valinta == 1)
                        {
                            Console.WriteLine("Ostit Haarniskan ja tunnet itsesi voimakkaammaksi (-5 gold)");
                            player.Health += 5;
                            player.Money -= 5;
                        }
                        if (valinta == 2)
                        {
                            Console.WriteLine("Ostit kypärän ja tunnet itse voimakkaammaksi (-5 gold)");
                            player.Health += 5;
                            player.Money -= 5;
                        }
                        if (valinta == 3)
                        {
                            Console.WriteLine("Ostit Taikajuoman joka maksoi 5 kultaa");
                            player.potion++;
                            player.Money -= 5;
                        }
                        if (valinta == 4)
                        {
                            Console.WriteLine("Ostit miekan ja tunnet miekan voimakkaammaksi (-5 gold)");
                            player.atk++;
                            player.Money -= 5;
                        }
                    }

                    if (valinta == 5)
                    {
                        continue;
                    }
                }


                // Katso jos pelaaja hävisi
                if (player.IsDefeated)
                {
                    Console.WriteLine("Gandalf tappoi sinut!");
                    return;
                }

                if (choice == 2)
                {
                    while (!enemy.IsDefeated)
                    {
                        // Printtaa battlen status
                        Console.WriteLine();
                        Console.WriteLine($"Seikkailijan elämät: {player.Health}");
                        Console.WriteLine($"Klonkun elämät: {enemy.Health}");

                        // Kysy pelaajalta action
                        Console.WriteLine("Mitä aiot tehdä?");
                        Console.WriteLine("1. Hyökkää!");
                        Console.WriteLine("2. Käytä liike");
                        Console.WriteLine($"3. Käytä taikajuoma (taikajuomien määrä : {player.potion})");
                        Console.WriteLine("4. Flee the fight");
                        Console.Write("Valinta: ");

                        int val = int.Parse(Console.ReadLine());

                        // Handlee pelaajan choice
                        switch (val)
                        {
                            case 1:
                                player.Attack(enemy);
                                break;
                            case 2:
                                player.UseAbility(enemy);
                                break;
                            case 3:
                                {
                                    if (player.potion > 0)
                                    {
                                        player.Health += 20;
                                        player.potion--;
                                    }
                                    if (player.potion <= 0)
                                    {
                                        Console.WriteLine("Sinulla ei ole taikajuomia");
                                    }
                                    break;
                                }
                            case 4:
                                Console.WriteLine("Lähdit pakoon pelkuri!");
                                return;
                            default:
                                Console.WriteLine("Eipä ollu!");
                                break;
                        }

                        // Katso jos vihollinen on kuollut
                        if (enemy.IsDefeated)
                        {
                            Console.WriteLine("Tapoit Klonkun!");
                            player.Money += 5;
                            break;
                        }

                        // Vihollinen hyokkää pelaajaan
                        enemy.Attack(player);

                        // Katso jos pelaaja on hävinnyt
                        if (player.IsDefeated)
                        {
                            Console.WriteLine("Klonkku tappoi sinut!");
                            return;
                        }
                    }
                }
                if (choice == 3)
                {
                    while (!enemy.IsDefeatedrit)
                    {
                        // Printtaa taistelun status
                        Console.WriteLine();
                        Console.WriteLine($"Pelaajan Elämät: {player.Health}");
                        Console.WriteLine($"Gandalfin Elämät: {enemy.gandalfhealth}");

                        // Kysy pelaajalta mitä tehdä
                        Console.WriteLine("Mitä aiot tehdä?");
                        Console.WriteLine("1. Hyökkää!");
                        Console.WriteLine("2. Käytä Liike");
                        Console.WriteLine($"3. Käytä taikajuoma (taikajuomien määrä: {player.potion})");
                        Console.WriteLine("4. Flee the fight!");
                        Console.Write("Valinta: ");

                        int val = int.Parse(Console.ReadLine());

                        // Handlaa pelaajan vastaus
                        switch (val)
                        {
                            case 1:
                                player.Attack(enemy);
                                break;
                            case 2:
                                player.UseAbility(enemy);
                                break;
                            case 3:
                                {
                                    if (player.potion > 0)
                                    {
                                        player.Health += 20;
                                    }
                                    if (player.potion <= 0)
                                    {   
                                        Console.WriteLine("Sinulla ei ole taikajuomia");
                                    }
                                    break;
                                }
                            case 4:
                                Console.WriteLine("Lähit menee pelkuri!");
                                return;
                            default:
                                Console.WriteLine("Eipä ollu!");
                                break;
                        }

                        // Kato jos vihu hävis
                        if (enemy.IsDefeatedrit)
                        {
                            Console.WriteLine("Tapoit Gandalfin!!");
                            player.Money += 10;
                            break;
                        }

                        // Vihollinen hyökkää pelaajaan
                        enemy.Attack(player);

                        // Katso jos pelaaja hävisi
                        if (player.IsDefeated)
                        {
                            Console.WriteLine("Gandalf tappoi sinut!");
                            continue;
                        }
                    }
                }
                if (choice == 4)
                {
                    while (!enemy.IsDefeatedloh)
                    {
                        // Printtaa taistelun status
                        Console.WriteLine();
                        Console.WriteLine($"Pelaajan elämät: {player.Health}");
                        Console.WriteLine($"Lohikäärmeen elämät: {enemy.sauronhealth}");

                        // Kysy pelaajalta mitä tehdä
                        Console.WriteLine("Mitä aiot tehdä?");
                        Console.WriteLine("1. Hyökkää!");
                        Console.WriteLine("2. Käytä liike");
                        Console.WriteLine($"3. Käytä taikajuoma (taikjuomien määrä : {player.potion})");
                        Console.WriteLine("4. Flee the fight!");
                        Console.Write("Valinta: ");

                        int val = int.Parse(Console.ReadLine());

                        // Handlaa pelaajan vastaus
                        switch (val)
                        {
                            case 1:
                                player.Attack(enemy);
                                break;
                            case 2:
                                player.UseAbility(enemy);
                                break;
                            case 3:
                                {
                                    if (player.potion > 0)
                                    {
                                        player.Health += 20;
                                    }
                                    if (player.potion <= 0)
                                    {
                                        Console.WriteLine("Sinulla ei ole taikajuomia");
                                    }
                                    break;
                                }
                            case 4:
                                Console.WriteLine("Lähdit pakoon pelkuri!");
                                return;
                            default:
                                Console.WriteLine("Eipä ollu!!");
                                break;
                        }

                        // Kato jos vhiollinen on kuollu
                        if (enemy.IsDefeatedloh)
                        {
                            Console.WriteLine("Tapoit Sauronin!!!");
                            player.Money += 20;
                            break;
                        }

                        //Vihollinen hyökkää pelaajaan
                        enemy.Attack(player);

                        // Katso jos pelaaja hävis
                        if (player.IsDefeated)
                        {
                            Console.WriteLine("Sauron tappoi sinut!");
                            continue;
                        }
                    }
                }
            }
        }
    }
}
