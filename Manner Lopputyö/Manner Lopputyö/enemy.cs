using System;

namespace KnightsQuest
{
    class Enemy
    {
        // The enemy's health
        public int Health { get; set; } = 50;
        public int Healthl { get; set; } = 150;
        public int Healthö { get; set; } = 80;


        // The enemy's attack damage
        public int AttackDamage { get; set; } = 5;

        // The enemy's weakness to the player's ability
        public bool IsWeakToAbility { get; set; } = false;

        // Whether the enemy is defeated
        public bool IsDefeated { get { return Health <= 0; } }

        // The enemy attacks the player
        public void Attack(Player player)
        {
            int damage = AttackDamage;
            Console.WriteLine($"Vihollinen hyökkää sinuun {damage} vahingolla!");
            player.TakeDamage(damage);
        }

        // The enemy takes damage from the player
        public void TakeDamage(int damage)
        {
            // Check if the player's ability is a weakness
            if (IsWeakToAbility)
            {
                damage *= 2;
                Console.WriteLine($"Hyökkäät vihollisesi herkkään paikkaan {damage} vahingolla!");
            }
            else
            {
                Console.WriteLine($"Sinä vahingoitit vihollista {damage} vahinkoa!");
            }

            Health -= damage;
        }
    }
}