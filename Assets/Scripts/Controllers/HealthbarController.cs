using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarController : MonoBehaviour
{
    private GameObject Healthbar;
    private GameObject Healthbar_Prefab;
    private Vector3 pos;
    private Vector3 offset = new Vector3(0.0f, -50.0f, 0.0f);
    private GameObject Canvas;
    public GameObject AttachedObject;
    public Slider SliderComponent;

    void Awake()
    {
        Healthbar_Prefab = Resources.Load<GameObject>("prefabs/HealthBar");
    }

    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Healthbar = Instantiate(Healthbar_Prefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Healthbar.transform.SetParent(Canvas.transform);
        pos = Camera.main.WorldToScreenPoint(AttachedObject.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;
        SliderComponent = Healthbar.GetComponent<Slider>();
        if (AttachedObject.tag == "Player")
        {
            SliderComponent.maxValue = AttachedObject.GetComponent<PlayerController>().max_health;
            SliderComponent.value = AttachedObject.GetComponent<PlayerController>().max_health;
        }
        else
        {
            SliderComponent.maxValue = AttachedObject.GetComponent<EnemyController>().EnemyType.max_health;
            SliderComponent.value = AttachedObject.GetComponent<EnemyController>().EnemyType.max_health;
        }
    }
    
    void Update()
    {
        pos = Camera.main.WorldToScreenPoint(AttachedObject.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;

        if (SliderComponent.value == 0)
        {
            if (AttachedObject.tag == "Player")
            {
                // gameover or new life ?
            }
            else
            {
                Destroy(AttachedObject);
            }

        }

    }

    void OnDestroy()
    {
        Destroy(Healthbar);
    }
}
