using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float enemySpeed;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.down * enemySpeed * Time.deltaTime);
    }
}
