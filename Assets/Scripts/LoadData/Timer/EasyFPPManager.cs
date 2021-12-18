using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyFPPManager : MonoBehaviour
{
    public GameObject Manager;
    // Start is called before the first frame update
    void Start()
    {
        Manager.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ender()
    {
        Manager.SetActive(false);
    }
}
