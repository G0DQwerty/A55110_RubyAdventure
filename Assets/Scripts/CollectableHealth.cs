using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableHealth : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }
    //Step 9
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log("Object that entered the trigger : " + other);
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}
