using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Controller : MonoBehaviour
{
    public float speed = 2.0f;
    private Vector3 target;
    private Vector3 position;
    private Camera cam;
    private float angle = 0;
    public Player_Weapon DefaultWeapon;
    public Player_Weapon AlternateWeapon;

    void Awake()
    {
       // Weapon = gameObject.GetComponent<Player_Weapon>();
        cam = Camera.main;
    }

    void Start()
    {
        target = new Vector3(0.0f, 0.0f);
        position = gameObject.transform.position;
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
        if (Input.GetKey(KeyCode.Mouse0))
        {
            DefaultWeapon.FireWeapon(Camera.main.ScreenToWorldPoint(mousePos));
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            AlternateWeapon.FireWeapon(Camera.main.ScreenToWorldPoint(mousePos));
        }
    }

    public void Move()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");

        target = new Vector3(0.0f + horizontalAxis, 0.0f + verticalAxis);
        //if (Input.GetKey(KeyCode.LeftArrow))
        //    target += Vector3.left;
        //if (Input.GetKey(KeyCode.RightArrow))
        //    target += Vector3.right;
        //if (Input.GetKey(KeyCode.DownArrow))
        //    target += Vector3.down;
        //if (Input.GetKey(KeyCode.UpArrow))
        //    target += Vector3.up;
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + target, step);

        if (target != Vector3.zero)
            angle = Mathf.Atan2(-target.y, -target.x) * Mathf.Rad2Deg + 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
    
}
