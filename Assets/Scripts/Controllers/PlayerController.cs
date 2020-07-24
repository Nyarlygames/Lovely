using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private AnimationController AnimController;
    private InputController InputController;
    private WeaponController WeapController;
    public int health = 100;
    private HealthbarController HealthController;

    void Awake()
    {
        HealthController = gameObject.AddComponent<HealthbarController>();
        HealthController.AttachedObject = gameObject;
    }

    void Start()
    {
    }


    void Update()
    {
    }
    

    void OnTriggerEnter2D(Collider2D col)
    {
    }
}
