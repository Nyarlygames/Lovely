using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    public int max_health;
    public int health;
    public string sprite;
    public float speed = 1.0f;
    public int destroy_damage = 1;
    public Weapon weapon;
    public Enemy_Behaviour behaviour = new Behaviour_Default();

}
