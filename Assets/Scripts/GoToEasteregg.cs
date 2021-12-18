using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToEasteregg : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(Input.GetKeyDown(KeyCode.H))
        {//SceneManager.LoadScene("Yeesteregg");
        Debug.Log("esteregg");}
    }
}
