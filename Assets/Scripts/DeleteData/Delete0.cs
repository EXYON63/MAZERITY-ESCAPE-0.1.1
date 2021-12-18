using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete0 : MonoBehaviour
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
        PlayerPrefs.DeleteKey("PlayerX0");
        PlayerPrefs.DeleteKey("PlayerY0");
        PlayerPrefs.DeleteKey("PlayerZ0");
        PlayerPrefs.DeleteKey("Time0");
    }
}
