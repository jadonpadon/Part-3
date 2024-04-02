using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallTank : EnemyBehaviour
{
    private static float initialSpeed = 2;

    public static float InitialSpeed
    {
        get { return initialSpeed; }
        set { initialSpeed = value; }
    }

    protected override void Start()
    {
        base.Start();
        StartCoroutine(SlowDownAfterDelay(1));
    }

    IEnumerator SlowDownAfterDelay(float delay)
    {
        enemySpeed = initialSpeed;
        float t = 0.0f;
        while (t < delay)
        {
            t += Time.deltaTime;
            yield return null;
        }
        enemySpeed = 1;
    }
}
