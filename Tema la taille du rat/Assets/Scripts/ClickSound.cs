using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource[] audios;
    public GameObject part;
    void Start()
    {
        audios = gameObject.GetComponents<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        part.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            LetsPlay();
            part.gameObject.GetComponent<ParticleSystem>().Play();
        }
    }

    public void LetsPlay()
     {
         int clipPick = Random.Range(0, audios.Length-1);
         audios[clipPick].Play();
     }
     IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
