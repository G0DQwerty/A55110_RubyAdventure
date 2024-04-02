using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Step 10
        //QualitySettings.vSyncCount = 0;
        //Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Step 3
        //float horizontal = Input.GetAxis("Horizontal");
        //Debug.Log(horizontal);
        //Vector2 position = transform.position;
        //position.x = position.x + 0.1f * horizontal;
        //transform.position = position;

        //Step 9
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector2 position = transform.position;
        //position.x = position.x + 0.1f * horizontal;
        //position.y = position.y + 0.1f * vertical;
        //transform.position = position;

        //Step 10
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //Vector2 position = transform.position;
        //position.x = position.x + 0.1f * horizontal;
        //position.y = position.y + 0.1f * vertical;
        //transform.position = position;

        //Step 11
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal * speed * Time.deltaTime;
        position.y = position.y + 0.1f * vertical * speed * Time.deltaTime;
        transform.position = position;
    }
}
