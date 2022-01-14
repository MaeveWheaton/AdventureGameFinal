using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameFinal.Classes
{
    public class Character
    {
        public int x, y, speed, health, money, weapon;
        public string image;
        public List<Weapon> weaponType;


        public void Move(string direction)
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
                case "leftup":
                    x -= speed;
                    y -= speed;
                    break;
                case "leftdown":
                    x -= speed;
                    y += speed;
                    break;
                case "rightup":
                    x += speed;
                    y -= speed;
                    break;
                case "rightdown":
                    x += speed;
                    y += speed;
                    break;
            }
        }
    }

    public class Player : Character 
    {
        public bool shielded;
        Random rand = new Random();
        int specialAttackAdd;

        public Player(int _x, int _y, int _speed, int _health, int _money, List<Weapon> _weaponType, int _weapon, bool _shielded, string _image)
        {
            x = _x;
            y = _y;
            speed = _speed;
            health = _health;
            money = _money;
            weaponType = _weaponType;
            weapon = _weapon;
            shielded = _shielded;
            image = _image;
        }

        public void Combat(string action, int weaponStrength, NPC monster)
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
                    specialAttackAdd = rand.Next(3, 9);
                    monster.health -= weaponStrength + specialAttackAdd;
                    break;
                case "waiting":
                    break;
                default:
                    break;
            }
        }
    }

    public class NPC : Character
    {
        string type;

        public NPC(int _x, int _y, int _health, List<Weapon> _weaponType, string _type, string _image)
        {
            x = _x;
            y = _y;
            health = _health;
            weaponType = _weaponType;
            type = _type;
            image = _image;
        }

        public void Combat(Player player, int weaponStrength, int shieldStrength)
        {
            //If player shielded, weapon attack - shield strength, remove health
            //Else, reduce player health by weapon strength
            if (player.shielded)
            {
                if(shieldStrength > weaponStrength)
                {

                }
                else
                {
                    player.health -= weaponStrength - shieldStrength;
                }
            }
            else
            {
                player.health -= weaponStrength;
            }
        }

    }
}
