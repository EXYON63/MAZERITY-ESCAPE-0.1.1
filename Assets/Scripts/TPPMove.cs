using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPPMove : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
