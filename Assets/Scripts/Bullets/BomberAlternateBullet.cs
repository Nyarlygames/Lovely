using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberAlternateBullet : Bullet
{
    public BomberAlternateBullet()
    {
        BulletSpeed = 2.0f;
        damage = 1.0f;
        sprite = Resources.Load<Sprite>("gfx/tir");
    }
}
