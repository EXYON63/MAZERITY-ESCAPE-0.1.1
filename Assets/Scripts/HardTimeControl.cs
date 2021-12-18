using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardTimeControl : MonoBehaviour
{
    public GameObject Menu;
    public GameObject End;
    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(false);
        End.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Menu.activeSelf == false && End.activeSelf == false)
        {
            Time.timeScale = 1;
            Cursor.visible = false;
        }

        if(Menu.activeSelf == true || End.activeSelf == true)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
        }
    }
}
