using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{

    [SerializeField] private GameObject blink1;
    
    private void Start()
    {
        blink1.SetActive(false);
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Blink")
        {
            Invoke("EnableBlink", 0f);
            Invoke("DisableBlink", 0.1f);
        }

    }

    private void EnableBlink()
    {
        blink1.SetActive(true);
        
    }
    private void DisableBlink()
    {
        blink1.SetActive(false);
        
    }
}
