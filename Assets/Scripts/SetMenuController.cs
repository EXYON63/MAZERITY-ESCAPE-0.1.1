using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetMenuController : MonoBehaviour
{
    public GameObject Menu;
    public GameObject exit;
    public GameObject setter;
    public GameObject setunit;
    public GameObject exitunit;
    public GameObject text;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Menu.activeSelf == true)
            {
                Menu.SetActive(false);
                
            }
            else
            {
                Menu.SetActive(true);
                setunit.SetActive(false);
                exit.SetActive(false);
                setter.SetActive(true);
                text.SetActive(false);
            }
        }
    }

    public void resume()
    {
        Menu.SetActive(false);
    }

    public void option()
    {
        setter.SetActive(false);
        setunit.SetActive(true);
        
        
    }

    public void exitgamewithoutsave()
    {
        exitunit.SetActive(false);
        exit.SetActive(true);
    }

    
    public void noexitgame()
    {
        setunit.SetActive(true);
        exit.SetActive(false);
    }

    public void yesexitgame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsaveeasyfpp()
    {
        PlayerPrefs.SetFloat("PlayerX0", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY0", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ0", player.transform.position.z);
        //PlayerPrefs.SetFloat("Time0", LimitTime);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsaveeasytpp()
    {
        PlayerPrefs.SetFloat("PlayerX1", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY1", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ1", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavnormalfpp()
    {
        PlayerPrefs.SetFloat("PlayerX2", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY2", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ2", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavnormaltpp()
    {
        PlayerPrefs.SetFloat("PlayerX3", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY3", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ3", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavhardfpp()
    {
        PlayerPrefs.SetFloat("PlayerX4", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY4", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ4", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavhardtpp()
    {
        PlayerPrefs.SetFloat("PlayerX5", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY5", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ5", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavtutorialfpp()
    {
        PlayerPrefs.SetFloat("PlayerX6", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY6", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ6", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    public void exitgamewithsavtutorialtpp()
    {
        PlayerPrefs.SetFloat("PlayerX7", player.transform.position.x);
        PlayerPrefs.SetFloat("PlayerY7", player.transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ7", player.transform.position.z);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MainScene");
    }

    void Awake()
    {
        //GameObject.Find("Manager").GetComponent<Timer>().LimitTime;
        //LoadData();
    }

    
}
