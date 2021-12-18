using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControl : MonoBehaviour
{
    public GameObject Menu;
    public GameObject End;
    public GameObject wholemap;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Menu.activeSelf == false && End.activeSelf == false && wholemap.activeSelf == false)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
        }

        if(Menu.activeSelf == true || End.activeSelf == true || wholemap.activeSelf == true)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        
    }
}
