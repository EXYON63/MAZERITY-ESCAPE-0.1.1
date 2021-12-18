using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTutFPP : MonoBehaviour
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
        if(PlayerPrefs.HasKey("PlayerX6"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX6");
        float y = PlayerPrefs.GetFloat("PlayerY6");
        float z = PlayerPrefs.GetFloat("PlayerZ6");
        //float time = PlayerPrefs.GetFloat("Time0");

        player.transform.position = new Vector3(x, y, z);
        }

        else
        {
            Debug.Log("No SavedData!");
        }
        
    }

    void Awake()
    {
       // GameObject.Find("Manager").GetComponent<Timer>().LimitTime;
        LoadData();
    }
}
