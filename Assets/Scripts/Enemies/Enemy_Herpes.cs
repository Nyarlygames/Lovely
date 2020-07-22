using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Herpes : Enemy
{
    public Enemy_Herpes()
    {
        sprite = "gfx/herpes";
        health = 10;
        weapon = new DefaultWeapon();
    }
}
