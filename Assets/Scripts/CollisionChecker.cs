using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay()
    {
        if(Input.GetKeyDown(KeyCode.X) && Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("Collision");
            SceneManager.LoadScene("Yeesteregg");
        }
        
    }
    
}
