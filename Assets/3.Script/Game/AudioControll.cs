using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class AudioControll : MonoBehaviour
{
    [SerializeField] AudioSource source;
 
  
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

 


    public void BackAudio()
    {
        Debug.Log(source.time);

        
        source.time -= 5f;
        if (source.time <= 0)
        {
            source.time = 0;
        }
    }



    /*public void Slider_value()
    {
        float value = slider.value * clip.length;
        Debug.Log(value);
        source.time = value;
    }*/


}

