using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public int currentGold;

    // public damageToGive;
    public Text goldText;
    public float moveSpeed = 1.0f;
    public Vector3 moveVector;
    //  public Text textbox; 
    //CurrentHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        // textbox = GetComponent<Text>("Health");
    }

    // Update is called once per frame
    void Update()
    {
        //   Health += damageToGive; 
        // textbox.text = "Health" - damageToGive;
    }

    public void AddGold(int goldToAdd)
    {

        currentGold += goldToAdd;
        goldText.text = "Gold: " + currentGold;

       if (currentGold == 20) { SceneManager.LoadScene("WinScene");}
    }
}

   











