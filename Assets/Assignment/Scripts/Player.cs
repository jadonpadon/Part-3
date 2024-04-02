using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject missile;

    void Start()
    {
        
    }

    void Update()
    {
        //rotate to follow mouse
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;

        //shoot
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(missile, transform.position, transform.rotation);
        }
    }
}
