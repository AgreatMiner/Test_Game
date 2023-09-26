using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Ctrl : MonoBehaviour
{
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterMove();
    }

    public void CharacterMove()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ani.SetBool("Move", true);
            Debug.Log("work");
        }
        else
        {
            ani.SetBool("Move", false);
        }
    }
}
