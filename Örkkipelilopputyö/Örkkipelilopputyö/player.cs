using System;

namespace Örkkipelilopputyö
{
    class Player
    {
        // Pelaajan elämät
        public int Health { get; set; } = 100;

        // pelaajan atk dmg
        public int atk { get; set; } = 10;

        // liikkeen cooldown vuoroissa
        public int abilitycd { get; set; } = 3;

        // Monta vuoroa ennen ku voi käyttää uusiks
        private int abilityCooldownRemaining = 0;

        // Onko pelaaja kuollut
        public bool IsDefeated { get { return Health <= 0; } }

        public int Money { get; set; } = 0;

        public int potion { get; set; } = 0;

        // Pelaaja hyökkää viholliseen
        public void Attack(Enemy enemy)
        {
            int damage = atk;
            Console.WriteLine($"Sinä hyökkäät viholliseen ja teet {damage} damagea!");

            // Laita damaget vihuun
            enemy.TakeDamage(damage);
        }

        // PElaaja käyttää liikkeen vihuun
        public void UseAbility(Enemy enemy)
        {
            // Kato jos taika on valmis
            if (abilityCooldownRemaining > 0)
            {
                Console.WriteLine("Taikasi ei ole vielä valmis!");
                return;
            }

            int damage = atk * 2;
            Console.WriteLine($"Käytät taikaa ja teet {damage} damagea!");

            // Laita damaget vihuun
            enemy.TakeDamage(damage);

            // katso abilitycooldowni
            abilityCooldownRemaining = abilitycd;
        }

        // Pelaaja ottaa vihollisista damagea
        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"sinä otat {damage} damagea viholliselta!");
        }
    }
}
