using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPakestColor = Color.white;
    [SerializeField] Color32 noPaskestColor = Color.white;
    [SerializeField] float DestroyDelay = 0.5f;
    bool flag = false;

    SpriteRenderer spirteRender;
    void Start()
    {
        spirteRender = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "packest" && flag == false)
        {
            Debug.Log("đã lấy");
            flag = true;
            spirteRender.color = hasPakestColor;
            Destroy(collision.gameObject, DestroyDelay);

        }
        else if (collision.tag == "destination" && flag == true)
        {
            Debug.Log("đã trả hàng");
            flag = false;
            spirteRender.color = noPaskestColor;
        }
    }
    //  void FixedUpdate(Collider2D collision) {
    //     OnCollisionEnter2D(collision);
    // }
}
