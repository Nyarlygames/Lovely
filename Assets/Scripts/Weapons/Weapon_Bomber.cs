using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Bomber : Weapon
{
    public Weapon_Bomber()
    {
        MainBullet = new AnotherBullet();
        AlternateBullet = new DefaultBullet();
    }
}
