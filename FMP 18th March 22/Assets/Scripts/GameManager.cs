using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int currentGold;
  
    public Text goldText;
    public float moveSpeed = 1.0f;
    public Vector3 moveVector;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGold(int goldToAdd) {
        
        currentGold += goldToAdd;
        goldText.text = "Gold: " + currentGold;

    
    }



}
