using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public GameObject shadowon;
    public GameObject shadowoff;
    public GameObject bgmon;
    public GameObject bgmoff;
    public GameObject colon;
    public GameObject coloff;
    public GameObject panel;
    public GameObject setter;
    public AudioSource audioSource;
    public AudioSource player;
    
    // Start is called before the first frame update
    void Awake()
    {
        shadowon.SetActive(true);
        shadowoff.SetActive(false);
        bgmon.SetActive(true);
        bgmoff.SetActive(false);
        colon.SetActive(true);
        coloff.SetActive(false);
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//그림자
    public void shadowturnoff()
    {//그림자 끄기
        Debug.Log("shadow Off");
        QualitySettings.shadows = ShadowQuality.Disable;
        shadowon.SetActive(false);
        shadowoff.SetActive(true);
    }

    public void shadowturnon()
    {//그림자 켜기
        Debug.Log("shadow On");
        QualitySettings.shadows = ShadowQuality.All;
        shadowoff.SetActive(false);
        shadowon.SetActive(true);
    }
//bgm
    public void bgmturnoff()
    {//bgm 끄기
        Debug.Log("bgm Off");
        audioSource.Stop();
        bgmon.SetActive(false);
        bgmoff.SetActive(true);
    }

    public void bgmurnon()
    {//bgm 켜기
        Debug.Log("bgm On");
        audioSource.Play();
        bgmoff.SetActive(false);
        bgmon.SetActive(true);
    }
//col
    /*public void colturnoff()
    {//col 끄기
        Debug.Log("col Off");
        player.enabled = false;
        colon.SetActive(false);
        coloff.SetActive(true);
    }

    public void colturnon()
    {//col 켜기
        Debug.Log("col On");
        player.enabled = true;
        coloff.SetActive(false);
        colon.SetActive(true);
    }*/

    public void exitset()
    {
        Debug.Log("exit setting");
        panel.SetActive(false);
        setter.SetActive(true);
    }
}
