using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if esc is pressed, quit the application
        if(Input.GetKeyDown(KeyCode.'1')){
            Debug.Log("esc pressed");
            Application.Quit();        }
    }
}
