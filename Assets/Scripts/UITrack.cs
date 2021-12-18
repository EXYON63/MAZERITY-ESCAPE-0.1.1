using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITrack : MonoBehaviour
{
    public GameObject Arrow;
    public GameObject EndBlock;
    // Start is called before the first frame update
    void Start()
    {
        Arrow = GameObject.Find("Canvas/Image");
    }

    // Update is called once per frame
    void Update()
    {
        if(Arrow)
        {
            Arrow.transform.position = Camera.main.WorldToScreenPoint(EndBlock.transform.position + new Vector3(0, 8f, 0));
        }
    }
}
