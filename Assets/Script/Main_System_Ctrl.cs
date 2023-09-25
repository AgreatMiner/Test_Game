using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_System_Ctrl : MonoBehaviour
{
    public Text name;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Start_Game()
    {
        if (name.text != null)
        {
            Debug.Log(name.text);
        }
    }
}
