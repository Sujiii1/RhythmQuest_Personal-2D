using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll_Intro : MonoBehaviour
{
    [SerializeField] private float Speed = 0;

    private void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        /*if (GameManager.Instance.isGameOver)
        {
            
        }*/
    }
}
