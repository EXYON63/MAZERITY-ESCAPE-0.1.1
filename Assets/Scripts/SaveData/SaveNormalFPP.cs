using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveNormalFPP : MonoBehaviour
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
        PlayerPrefs.SetFloat("PlayerX2", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY2", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ2", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }
}
