using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private AnimationController AnimController;
    private InputController InputController;
    private WeaponController WeapController;
    public int max_health = 100;
    public int health;
    private HealthbarController HealthController;

    void Awake()
    {
        health = max_health;
        HealthController = gameObject.AddComponent<HealthbarController>();
        HealthController.AttachedObject = gameObject;
    }

    void Start()
    {
    }


    void Update()
    {
        HealthController.SliderComponent.value = health;
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy_Bullet")
        {
            health -= col.gameObject.GetComponent<BulletController>().weapon.damage;
            Destroy(col.gameObject);
        }
    }
}
