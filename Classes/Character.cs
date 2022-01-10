using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameFinal.Classes
{
    public class Character
    {
        public int x, y, speed, health, money;
        public string weapon;

        public Character()
        {

        }

        void Move(string direction)
        {
            switch (direction)
            {
                case "up":
                    y -= speed;
                    break;
                case "right":
                    x += speed;
                    break;
                case "down":
                    y += speed;
                    break;
                case "left":
                    x -= speed;
                    break;
            }
        }
    }

    public class Player : Character 
    {
        public bool shielded;

        public Player(int _x, int _y, int _speed, int _health, int _money, string _weapon, bool _shielded)
        {
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            money = _money;
            weapon = _weapon;
            shielded = _shielded;
        }

        void Combat(string action, int weaponStrength, NPC monster)
        {
            //If attack, reduce monster health by weapon strength
            //If defend, set character to shield up
            //If specialAttack, get random value(from weapon strength + 1 to + 5?), reduce monster health
            switch (action)
            {
                case "attack":
                    monster.health -= weaponStrength;
                    break;
                case "defend":
                    shielded = true;
                    break;
                case "specialAttack":
                    break;
                default:
                    break;
            }
        }
    }

    public class NPC : Character
    {
        string type;

        public NPC(int _x, int _y, int _health, string _weapon, string _type)
        {
            x = _x;
            y = _y;
            health = _health;
            weapon = _weapon;
            type = _type;
        }

        void Combat(Player player, int weaponStrength, int shieldStrength)
        {
            //If player shielded, weapon attack - shield strength, remove health
            //Else, reduce player health by weapon strength
            if (player.shielded)
            {
                player.health -= weaponStrength - shieldStrength;
            }
            else
            {
                player.health -= weaponStrength;
            }
        }

    }
}
