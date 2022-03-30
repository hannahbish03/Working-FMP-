using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSpin : MonoBehaviour
{
    [SerializeField] float turnSpeed = 90f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);
    }
}
