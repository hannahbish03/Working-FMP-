using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float knockBackForce;
    public float knokBackTime;
    private float knokBackCounter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (KnockBackCounter <= 0)
        {

            moveDirection.y = jumpForce;

        }
    }

    else 
   {

      KnockBackCounter -= Time.deltaTime;

}   }
    
    
    public void KnockBack() {


        knockBackCounter = knockBackTime;
    }


}
