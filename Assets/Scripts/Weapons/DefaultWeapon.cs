using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeapon : Weapon
{
    public DefaultWeapon()
    {
        MainBullet = new DefaultBullet();
        AlternateBullet = new AnotherBullet();
        Fire_Rate = 0.1f;
        Alternate_Fire_Rate = 2.0f;
        damage = 5;
    }
}
