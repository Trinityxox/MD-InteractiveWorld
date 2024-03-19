using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button1 : MonoBehaviour
{

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ui.SetActive(true);
        }
    }

    public void CloseUI()
    {
            ui.SetActive(false);
    }
}
