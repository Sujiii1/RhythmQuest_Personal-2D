using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieEffect : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(EffectPrefabs());

    }
    private IEnumerator EffectPrefabs()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);

    }
}
