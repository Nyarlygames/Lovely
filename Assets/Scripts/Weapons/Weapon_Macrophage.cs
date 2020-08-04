using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Macrophage : Weapon
{
   
    public Weapon_Macrophage()
    {
        Fire_Rate = 1.0f;
        Alternate_Fire_Rate = 1.0f;
        AlternateBullet = new BomberAlternateBullet();
        damage = 1;
    }

}
