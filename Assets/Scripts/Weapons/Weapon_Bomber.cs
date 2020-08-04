using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Bomber : Weapon
{
    public Weapon_Bomber()
    {
        MainBullet = new BomberBullet();
        AlternateBullet = new BomberAlternateBullet();
        damage = 10;
    }
}
