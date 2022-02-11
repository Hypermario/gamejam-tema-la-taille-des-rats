using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject playerA, playerB, gameOverSprite;


    void Start()
    {
        //player = GameObject.FindGameObjectsWithTag("Player");
    }


    void Update()
    {
        if(playerA == null && playerB == null){
            gameOverSprite.SetActive(true);
        }
    }
}
