using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float sturnSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmout = Input.GetAxis("Horizontal") * sturnSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        if (moveAmout >= 0)
        {
            transform.Rotate(0, 0, -steerAmout);
            transform.Translate(0, moveAmout, 0);
        }
        else
        {
            transform.Rotate(0, 0, steerAmout);
            transform.Translate(0, moveAmout, 0);
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boost")
        {
            moveSpeed = boostSpeed ; 
        }
        else if(other.tag == "slow"){
            moveSpeed = slowSpeed;
        }
    }
}
