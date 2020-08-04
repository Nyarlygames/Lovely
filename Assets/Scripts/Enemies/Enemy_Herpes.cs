using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Herpes : Enemy
{
    public Enemy_Herpes()
    {
        sprite = "gfx/herpes";
        health = 10;
        max_health = 10;
        speed = 1f;
        destroy_damage = 5;
        weapon = new DefaultWeapon();
        behaviour = new Behaviour_Herpes();
    }
}
