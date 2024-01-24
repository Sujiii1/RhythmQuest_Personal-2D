using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScroll : MonoBehaviour
{
    [SerializeField] private float Speed = 0;

    private void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
        /*if (GameManager.Instance.isGameOver)
        {
            
        }*/
    }
}
