using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveHardFPP : MonoBehaviour
{
    public GameObject player;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        PlayerPrefs.SetFloat("PlayerX4", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY4", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ4", player.transform.position.z);
        //PlayerPrefs.SetFloat("Time4", timer.text);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");   
    }
}