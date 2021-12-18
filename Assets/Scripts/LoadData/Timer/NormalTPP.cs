using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NormalTPP : MonoBehaviour
{
    public Text Timer;
    public float time1;
    public GameObject Manager;
    public Text EndTimer;
    // Start is called before the first frame update
    void Awake()
    {
        if(PlayerPrefs.HasKey("Time3"))
        {time1 = PlayerPrefs.GetFloat("Time3"); //time1값 불러오기
        }
    }

    // Update is called once per frame
    void Update()
    {
        time1 += Time.deltaTime;
        //Timer.text = "Time : " + (Mathf.Floor(time1 * 100)/100); //텍스트에 적용
        if(time1 < 60)
        {
            Timer.text = "Time : " + (Mathf.Floor(time1 * 100)/100) + "s"; //텍스트에 적용
            EndTimer.text = "your record : " + (Mathf.Floor(time1 * 100)/100) + "s";
        }
        else
        {
            Timer.text = "Time : " + (Mathf.Floor(time1/60)) + "m" + (Mathf.Floor(time1 * 100)/100 - (Mathf.Floor(time1/60) * 60)) + "s"; //텍스트에 적용
            Timer.text = "Your record : " + (Mathf.Floor(time1/60)) + "m" + (Mathf.Floor(time1 * 100)/100 - (Mathf.Floor(time1/60) * 60)) + "s";
        }
        if(Manager.activeSelf == false)
        {
            PlayerPrefs.SetFloat("Time3", time1);
            SceneManager.LoadScene("MainScene");
        }
    }

    /*public void SaveTime()
    {
        PlayerPrefs.SetFloat("Time4", time1); //마지막 타임 값 저장
    }*/
}
