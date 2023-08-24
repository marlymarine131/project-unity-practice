using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    // Start is called before the first frame update
    // this thing position(camera) should be in the same as the car's position
    
    [SerializeField] GameObject thingToFollow;
    
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
