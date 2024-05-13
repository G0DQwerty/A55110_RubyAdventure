using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Controler controller = other.GetComponent<Controler>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
