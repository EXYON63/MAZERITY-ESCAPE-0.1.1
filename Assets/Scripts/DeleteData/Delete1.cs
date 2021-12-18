using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete1 : MonoBehaviour
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
        PlayerPrefs.DeleteKey("PlayerX1");
        PlayerPrefs.DeleteKey("PlayerY1");
        PlayerPrefs.DeleteKey("PlayerZ1");
        PlayerPrefs.DeleteKey("Time1");
    }
}
