using Örkkipelilopputyö;
using System;

namespace Örkkipelilopputyö
{
    class Enemy
    {
        // The enemy's health
        public int Health { get; set; } = 50;

        public int gandalfhealth { get; set; } = 75;

        public int sauronhealth { get; set; } = 150;
        // The enemy's attack damage
        public int AttackDamage { get; set; } = 5;

        // The enemy's weakness to the player's ability
        public bool IsWeakToAbility { get; set; } = false;

        // Whether the enemy is defeated
        public bool IsDefeated { get { return Health <= 0; } }
        public bool IsDefeatedloh { get { return sauronhealth <= 0; } }
        public bool IsDefeatedrit { get { return gandalfhealth <= 0; } }

        // The enemy attacks the player
        public void Attack(Player player)
        {
            int damage = AttackDamage;
            Console.WriteLine($"Vihollinen hyökkää sinuun ja tekee {damage} damagea!");
            player.TakeDamage(damage);
        }

        // Vihollinen ottaa pelaajasta damagea
        public void TakeDamage(int damage)
        {
            // Katso jos liike on heikkous
            if (IsWeakToAbility)
            {
                damage *= 2;
                Console.WriteLine($"Sinä isket miekallasi ja viiltosi tekee {damage} damagea!");
            }
            else
            {
                Console.WriteLine($"Miekkasi viiltää vihollista {damage} damagea!");
            }

            Health -= damage;
            gandalfhealth -= damage;
            sauronhealth -= damage;
        }
    }
}