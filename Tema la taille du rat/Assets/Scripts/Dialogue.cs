using System;
using Random=UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Line[] textes;
    public float showTimer;
    public Text text;
    public Image[] images;

    public AudioSource[] audios;

    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        audios = gameObject.GetComponents<AudioSource>();
        for (int i = 0; i < textes.Length; i++)
        {
            yield return StartCoroutine(ShowTextCoroutine(textes[i]));
        }
    }

    IEnumerator ShowTextCoroutine(Line curLine)
    {
        for (int i = 0; i < images.Length; i++)
        {
            Color c = images[i].color;
            c.a = 0.5f;
            images[i].color = c;
        }
        Color newColor = curLine.image.color;
        newColor.a = 1f;
        curLine.image.color = newColor;

        newColor = curLine.image2.color;
        newColor.a = 1f;
        curLine.image2.color = newColor;

        text.text = curLine.text;
        LetsPlay();
        yield return new WaitForSeconds(showTimer);
    }
    public void LetsPlay()
     {
         int clipPick = Random.Range(0, audios.Length-1);
         audios[clipPick].Play();
     }
}

[Serializable]
public class Line
{
    public string text;
    public Image image;
    public Image image2;
}
     
 
     
