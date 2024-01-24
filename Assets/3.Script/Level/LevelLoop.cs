using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoop : MonoBehaviour
{
    private float width;

    void Start()
    {
        width = transform.GetComponent<BoxCollider2D>().size.x;
    }

    void Update()
    {
       /* if(GameManager.Instance.isGameOver)
        {
        return;
        }*/

        if (transform.position.x <= -width)
        {
            Vector2 offest = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + offest;

        }
    }
}
