using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveHardTPP : MonoBehaviour
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

    public void SaveData()
    {
        PlayerPrefs.SetFloat("PlayerX5", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY5", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ5", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }
}
