using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public Text text_Timer;
    public Text record;
    //float time;
    // Start is called before the first frame update
    void Start()
    {
        //float time = PlayerPrefs.GetFloat("Time4");
    }

    // Update is called once per frame
    public void Update()
    {
        /*LimitTime += Time.deltaTime;
        if(text_Timer)
        {
            text_Timer.text = "Time : " + (Mathf.Floor(LimitTime * 100)/100);
        }
        if(PlayerPrefs.HasKey("Time4"))
        {
            time += Time.deltaTime;
            text_Timer.text = time;
        }

        else
        {
            LimitTime += Time.deltaTime;
            text_Timer.text = "Time : " + (Mathf.Floor(LimitTime * 100)/100);
        }*/
        
    }

    void OnTriggerEnter()
    {
        if(record)
        {
            record.text = "Your record : " + (Mathf.Floor(LimitTime * 100)/100);
            //Time.timeScale = 0;
        }
    }

    
  
  
}
