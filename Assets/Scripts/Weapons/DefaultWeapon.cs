using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultWeapon : Weapon
{
    public DefaultWeapon()
    {
        MainBullet = new DefaultBullet();
        AlternateBullet = new AnotherBullet();
    }
}
