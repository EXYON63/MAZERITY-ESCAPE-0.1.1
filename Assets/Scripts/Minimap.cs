using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public GameObject wholemap;
    // Start is called before the first frame update
    void Start()
    {
        wholemap.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            if(wholemap.activeSelf == true)
            {
                wholemap.SetActive(false);
            }
            else
            {
                wholemap.SetActive(true);
            }
        }
    }
}
