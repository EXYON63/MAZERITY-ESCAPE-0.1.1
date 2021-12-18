using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNormalTPP : MonoBehaviour
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
        if(PlayerPrefs.HasKey("PlayerX3"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX3");
        float y = PlayerPrefs.GetFloat("PlayerY3");
        float z = PlayerPrefs.GetFloat("PlayerZ3");
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
