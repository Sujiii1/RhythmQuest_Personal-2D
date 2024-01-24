using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    //TrigerEnter2Dtag "Checkpoint" 
    //Sprite Color Change

    public Color newColor;
    private SpriteRenderer post;

    public static SceneControll instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.tag == "Player")
        {
            
            post = GetComponent<SpriteRenderer>();
            post.color = newColor;
            Debug.Log(newColor);
        }
    }*/  //ColorSprit

    
}
