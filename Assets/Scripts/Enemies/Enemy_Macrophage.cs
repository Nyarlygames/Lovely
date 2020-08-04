using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Macrophage : Enemy
{
    public Enemy_Macrophage(Vector3 position)
    {
        sprite = "gfx/aids";
        health = 50;
        max_health = 50;
        speed = 1f;
        destroy_damage = 5;
        weapon = new Weapon_Macrophage();
        behaviour = new Behaviour_Macrophage(position);
    }
}
