using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigTank : EnemyBehaviour
{
    public int health = 2;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        
        enemySpeed = 0;
        if(health == 2)
        {
            StartCoroutine(HitAnim(1.5f));
        }
        else if (health ==1)
        {
            Destroy(gameObject);
        }
        health--;

    }

    IEnumerator HitAnim(float duration)
    {
        float startRotation = transform.eulerAngles.z;
        float endRotation = startRotation + 360.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float zRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, zRotation);
            yield return null;
        }
        enemySpeed = 1;
    }

}
