using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Easteregg : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float RotateSpeed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.S))
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        transform.Rotate(0f, Input.GetAxis("Mouse X") * RotateSpeed, 0f, Space.World);
        //if(player.transform.rotation.x < 40 && player.transform.rotation.x > -40)
        transform.Rotate(-Input.GetAxis("Mouse Y") * RotateSpeed, 0f, 0f);
    }
}
