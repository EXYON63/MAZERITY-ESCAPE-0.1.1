using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        PlayerPrefs.DeleteKey("PlayerX2");
        PlayerPrefs.DeleteKey("PlayerY2");
        PlayerPrefs.DeleteKey("PlayerZ2");
        PlayerPrefs.DeleteKey("Time2");
    }
}
