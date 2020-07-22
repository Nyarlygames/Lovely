using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private AnimationController AnimController;
    private InputController InputController;
    private WeaponController WeapController;
    public int health = 100;
    
    void Awake()
    {
    }

    void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
    }


    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("collided");
        Debug.Log(col.collider.tag);
    }
}
