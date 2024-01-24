using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_sparkle : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(coinSparkle());

    }
    private IEnumerator coinSparkle()
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);

    }
}
