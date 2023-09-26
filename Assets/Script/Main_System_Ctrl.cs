using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_System_Ctrl : MonoBehaviour
{
    public Text name;
    public Text start;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseEnter()
    {
        start.color = Color.red;
    }

    public void OnMouseExit()
    {
        start.color = Color.black;
    }
    public void Start_Game()
    {
        if (name.text != null)
        {
            Debug.Log(name.text);
            SceneManager.LoadScene("Gaming");
        }
    }

}
