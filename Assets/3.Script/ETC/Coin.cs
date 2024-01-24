using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public Sprite GetCoin;
    public GameObject coinPrefab;

   /// [SerializeField] private AudioClip coinClip;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerManager.numberofCoins++;
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);

        } 
    }

}
