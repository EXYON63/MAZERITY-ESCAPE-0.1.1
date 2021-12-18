using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject EndPanel;
    public GameObject Timer;
    // Start is called before the first frame update
    void Start()
    {
        EndPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.K))
        //OnTriggerEnter();
    }

    void OnCollisionEnter()
    {
        EndPanel.SetActive(true);
        Debug.Log("Game End");
        Time.timeScale = 0;
        //Timer.transform.position = new Vector3(333, 100, -172);
        Timer.SetActive(false);
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("MainScene");
    }
}
