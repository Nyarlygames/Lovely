using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Playerobject;
    private AnimationController AnimController;
    private InputController InputController;
    private WeaponController WeapController;

    // Start is called before the first frame update
    void Awake()
    {
        AnimController = Playerobject.AddComponent<AnimationController>();
        AnimController.Init(Playerobject.GetComponent<SpriteRenderer>(), "gfx/sperma");
        WeapController = Playerobject.AddComponent<WeaponController>();
        InputController = Playerobject.AddComponent<InputController>();
        InputController.Weapon = WeapController;
    }

    void Start()
    {

    }


    void Update()
    {
        
    }
}
