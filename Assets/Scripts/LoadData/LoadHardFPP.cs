using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadHardFPP : MonoBehaviour
{
    public GameObject player;
    public Text Timer;
    public float time1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(PlayerPrefs.HasKey("Time4"))
        {
            Time4 += Time.deltaTime;
            Timer.text = "Time : " + (Mathf.Floor(Time4 * 100)/100);
        }
        else
        {
            time1 += Time.deltaTime;
            Timer.text = "Time : " + (Mathf.Floor(time1 * 100)/100);
        }*/
        
    }

    void LoadData()
    {
        if(PlayerPrefs.HasKey("PlayerX4"))
        {
            float x = PlayerPrefs.GetFloat("PlayerX4");
        float y = PlayerPrefs.GetFloat("PlayerY4");
        float z = PlayerPrefs.GetFloat("PlayerZ4");
        float Time4 = PlayerPrefs.GetFloat("Time4");
        //float time = PlayerPrefs.GetFloat("Time0");

        player.transform.position = new Vector3(x, y, z);
        //Timer.text = time;
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
