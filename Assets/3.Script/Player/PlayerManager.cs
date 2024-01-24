using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{


    public static Vector2 lastCheckPointPos = new Vector2(-3,0);
    public static int numberofCoins;
    public TextMeshProUGUI coinText;
    [SerializeField] AudioSource CoinSound;
    [SerializeField] AudioSource Level;
    //[SerializeField] AudioSource CheckSound;

    public GameObject Player;
    public Transform respawnPoint;


    private void Start()
    {
        //CoinSound = GetComponent<AudioSource>();
        //Level = GetComponent<AudioSource>();
        Level.Play();

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            StartCoroutine(Delay_co());
        }

        if (collision.CompareTag("Checkpoint"))
        {
           
            respawnPoint.position = Player.transform.position;

        }
       

        if (collision.CompareTag("Obstacle"))
        {

            Debug.Log("Touch");
            Player.transform.position = respawnPoint.position;
            StartCoroutine(Ob_re());

            BackAudio();
          /*  AudioControll audioControll = GetComponent<AudioControll>();
            audioControll.BackAudio();*/
        }
    }
    public void BackAudio()
    {
        Level.time -= 8f;
        if (Level.time <= 0)
        {
            Level.time = 0;
        }
    }



    private void Update()
    {
        Debug.Log(Level.time);

        coinText.text = "x" + numberofCoins;
        //Debug.Log(numberofCoins);

    }

    private IEnumerator Delay_co()
    {
        CoinSound.Play();
        yield return new WaitForSeconds(1f);
    }    
    private IEnumerator Ob_re()
    {
        //Level_1.Play();
        yield return new WaitForSeconds(5f);
    }


}
