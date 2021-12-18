using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHardTPP : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadData()
    {
        if(PlayerPrefs.HasKey("PlayerX5"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX5");
        float y = PlayerPrefs.GetFloat("PlayerY5");
        float z = PlayerPrefs.GetFloat("PlayerZ5");
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
        
    }
}
