using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Vector2 jumpVelocity;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            GetComponent<Rigidbody2D>().velocity = jumpVelocity;
        }
    }
}
