using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEasyTPP : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadData()
    {
        if(PlayerPrefs.HasKey("PlayerX1"))
        {
            float x1 = PlayerPrefs.GetFloat("PlayerX1");
        float y1 = PlayerPrefs.GetFloat("PlayerY1");
        float z1 = PlayerPrefs.GetFloat("PlayerZ1");
        //float time = PlayerPrefs.GetFloat("Time0");

        player.transform.position = new Vector3(x1, y1, z1);
        }

        
        
    }

    void Awake()
    {
        LoadData();
    }
}