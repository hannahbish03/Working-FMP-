using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentSpider : MonoBehaviour
{
    // Start is called before the first frame update

    GameManager gameManager;

    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("spider_pref");
        gameManager = gameController.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        
        transform.Translate(gameManager.moveVector * gameManager.moveSpeed * Time.deltaTime);
    }
}
