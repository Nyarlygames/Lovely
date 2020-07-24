using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsController : MonoBehaviour
{
    Sprite Bullet_1;
    Sprite Bullet_2;
    Sprite[] Anim_Bomber;
    Sprite[] Anim_Herpes;
    Sprite[] Anim_Player;
    GameObject PlayerPrefab;
    GameObject EnemyPrefab;
    GameObject Healthbar_Prefab;
    GameObject BulletPrefab;
    void Awake()
    {
        Bullet_1 = Resources.Load<Sprite>("gfx/tir2");
        Bullet_2 = Resources.Load<Sprite>("gfx/tir");
        Anim_Bomber = Resources.LoadAll<Sprite>("gfx/Bomber");
        Anim_Herpes = Resources.LoadAll<Sprite>("gfx/herpes");
        Anim_Player = Resources.LoadAll<Sprite>("gfx/sperma");
        PlayerPrefab = Resources.Load<GameObject>("prefabs/Player");
        EnemyPrefab = Resources.Load<GameObject>("prefabs/Enemy");
        Healthbar_Prefab = Resources.Load<GameObject>("prefabs/HealthBar");
        BulletPrefab = Resources.Load<GameObject>("prefabs/Bullet");
    }
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
