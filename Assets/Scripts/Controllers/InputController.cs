using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 target;
    private Vector3 position;
    private Camera cam;
    private float angle = 0;
    public WeaponController Weapon;

    void Start()
    {
        target = new Vector3(0.0f, 0.0f);
        position = gameObject.transform.position;
        cam = Camera.main;
    }

    void Update()
    {
        Move();
        CheckFire();
    }

    public void CheckFire()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Weapon.FireWeapon(0, Camera.main.ScreenToWorldPoint(mousePos));
        if (Input.GetKeyDown(KeyCode.Mouse1))
            Weapon.FireWeapon(1, Camera.main.ScreenToWorldPoint(mousePos));
    }

    public void Move()
    {
        target = new Vector3(0.0f, 0.0f);
        if (Input.GetKey(KeyCode.LeftArrow))
            target += Vector3.left;
        if (Input.GetKey(KeyCode.RightArrow))
            target += Vector3.right;
        if (Input.GetKey(KeyCode.DownArrow))
            target += Vector3.down;
        if (Input.GetKey(KeyCode.UpArrow))
            target += Vector3.up;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + target, step);

        if (target != Vector3.zero)
            angle = Mathf.Atan2(-target.y, -target.x) * Mathf.Rad2Deg + 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    
}
