using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Healthbar : MonoBehaviour
{
    private GameObject Healthbar;
    public GameObject Healthbar_Prefab;
    private Vector3 pos;
    private Vector3 offset = new Vector3(0.0f, -50.0f, 0.0f);
    private GameObject Canvas;
    public Enemy_Controller EnemyController;
    private Slider SliderComponent;

    void Awake()
    {
    }

    void Start()
    {
        Canvas = GameObject.FindGameObjectWithTag("Canvas");
        Healthbar = Instantiate(Healthbar_Prefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        Healthbar.transform.SetParent(Canvas.transform);
        pos = Camera.main.WorldToScreenPoint(EnemyController.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;
        SliderComponent = Healthbar.GetComponent<Slider>();
        SliderComponent.maxValue = EnemyController.max_health;
        SliderComponent.value = EnemyController.health;
    }

    void Update()
    {
        pos = Camera.main.WorldToScreenPoint(EnemyController.transform.position);
        pos = pos - offset;
        Healthbar.transform.position = pos;

        SliderComponent.value = EnemyController.health;
        if (SliderComponent.value == 0)
        {
            Destroy(EnemyController.gameObject);
        }

    }

    void OnDestroy()
    {
        Destroy(Healthbar);
    }
}
