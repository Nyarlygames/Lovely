using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bomber : Enemy
{
    public Enemy_Bomber()
    {
        sprite = "gfx/Bomber";
        health = 10;
        weapon = new Weapon_Bomber();
    }
}
