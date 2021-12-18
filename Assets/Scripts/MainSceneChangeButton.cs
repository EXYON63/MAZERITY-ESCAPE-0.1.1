using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneChangeButton : MonoBehaviour
{
    public GameObject Mainbutton;
    public GameObject Tutorial;
    public GameObject hardnessbutton;
    public GameObject easymode;
    public GameObject normalmode;
    public GameObject hardmode;
    public GameObject Exit;
    public GameObject load;
    // Start is called before the first frame update
    void Start()
    {
        Mainbutton.SetActive(true);
        hardnessbutton.SetActive(false);
        easymode.SetActive(false);
        normalmode.SetActive(false);
        hardmode.SetActive(false);
        Exit.SetActive(false);
        Tutorial.SetActive(false);
        load.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Mainbutton.SetActive(true);
        hardnessbutton.SetActive(false);
        easymode.SetActive(false);
        normalmode.SetActive(false);
        hardmode.SetActive(false);
        Exit.SetActive(false);
        Tutorial.SetActive(false);
        }
    }

    public void MainToHardness()
    {
        Mainbutton.SetActive(false);
        hardnessbutton.SetActive(true);
        Debug.Log("메인에서 난이도 전환");
    }

    public void HardnessToEasy()
    {
        hardnessbutton.SetActive(false);
        easymode.SetActive(true);
        Debug.Log("난이도에서 이지 전환");
    }

    public void HardnessToNormal()
    {
        hardnessbutton.SetActive(false);
        normalmode.SetActive(true);
        Debug.Log("난이도에서 노멀 전환");
    }

    public void HardnessToHard()
    {
        hardnessbutton.SetActive(false);
        hardmode.SetActive(true);
        Debug.Log("난이도에서 하드 전환");
    }

    public void EasyFPP()
    {
        SceneManager.LoadScene("EasyFPP");
        
    }

    public void EasyTPP()
    {
        SceneManager.LoadScene("EasyTPP");
    }

    public void NormalFPP()
    {
        SceneManager.LoadScene("NormalFPP");
    }

    public void NormalTPP()
    {
        SceneManager.LoadScene("NormalTPP");
    }

    public void HardFPP()
    {
        SceneManager.LoadScene("HardFPP");
    }

    public void HardTPP()
    {
        SceneManager.LoadScene("HardTPP");
    }

    public void Tutoriaload()
    {
        Mainbutton.SetActive(false);
        Tutorial.SetActive(true);
    }

    public void TutorialFPP()
    {
        SceneManager.LoadScene("TutorialFPP");
    }

    public void TutorialTPP()
    {
        SceneManager.LoadScene("TutorialTPP");
    }

    public void ApplicationExitAsk()
    {
        Exit.SetActive(true);
        Debug.Log("Will you exit?");
    }

    public void ExitYes()
    {
        Application.Quit();
        Debug.Log("applicationquit");
    }

    public void ExitNo()
    {
        Exit.SetActive(false);
    }

    
}
