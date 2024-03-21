using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject[] buildingParts;

    IEnumerator Start()
    {
        for (int i = 0; i < buildingParts.Length; i++)
        {
            buildingParts[i].SetActive(false);
        }
        yield return StartCoroutine(BuildInParts());
    }

    IEnumerator BuildInParts()
    {
        for (int i = 0; i < buildingParts.Length; i++)
        {
            buildingParts[i].SetActive(true);
            yield return StartCoroutine(ScaleIn(buildingParts[i].transform));
        }
    }

    IEnumerator ScaleIn(Transform objTransform)
    {
        float duration = 1.0f;
        Vector3 targetScale = objTransform.localScale;

        objTransform.localScale = Vector3.zero;

        float elapsedTime = 0;
        while (elapsedTime < duration)
        {
            objTransform.localScale = Vector3.Lerp(Vector3.zero, targetScale, (elapsedTime / duration));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        objTransform.localScale = targetScale;
    }
}
