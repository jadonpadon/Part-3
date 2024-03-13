using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    private Vector3 initialPos;
    public float dashSpeed = 10;
    public float dashDistance = 5;

    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {

        initialPos = transform.position;
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = destination - ((Vector2)transform.position);


        rb.velocity = direction.normalized * dashSpeed;

        base.Attack();
        Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);
        
    }

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(initialPos, transform.position);
        if (distance >= dashDistance)
        {
            rb.velocity = Vector2.zero;
            }
        }
}
