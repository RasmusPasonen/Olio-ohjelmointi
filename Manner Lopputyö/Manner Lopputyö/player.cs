using System;

namespace KnightsQuest
{
    class Player
    {
        // The player's health
        public int Health { get; set; } = 100;

        public int taikajuoma { get; set; } = 0;
        // The player's attack damage
        public int AttackDamage { get; set; } = 10;

        // The player's ability cooldown (in turns)
        public int AbilityCooldown { get; set; } = 3;

        // The number of turns until the player's ability can be used again
        private int abilityCooldownRemaining = 0;

        // Whether the player is defeated
        public bool IsDefeated { get { return Health <= 0; } }

        // The player attacks the enemy
        public void Attack(Enemy enemy)
        {
            int damage = AttackDamage;
            Console.WriteLine($"Hyökkäät viholliseen {damage} vahingolla!");

            // Apply damage to the enemy
            enemy.TakeDamage(damage);
        }

        // The player uses their ability on the enemy
        public void UseAbility(Enemy enemy)
        {
            // Check if the ability is still on cooldown
            if (abilityCooldownRemaining > 0)
            {
                Console.WriteLine("Liikettä ei voi vielä käyttää!");
                return;
            }

            int damage = AttackDamage * 2;
            Console.WriteLine($"Käytät liikkeen viholliseesi vahingoittaaksesi {damage} vahingolla!");

            // Apply damage to the enemy
            enemy.TakeDamage(damage);

            // Set the ability cooldown
            abilityCooldownRemaining = AbilityCooldown;
        }

        // The player takes damage from the enemy
        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"Sinä otat {damage} vahinkoa vihollisestasi!");
        }
    }
}