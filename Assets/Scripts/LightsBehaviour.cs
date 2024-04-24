using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBehaviour : MonoBehaviour
{

    public GameObject ui;

    public GameObject myLights;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
        myLights.SetActive(false);
        // myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        
        if(other.tag == "Player"){
                ShowUI();
        }
    }

    public void HideUI(){
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ShowUI(){
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes(){
        HideUI();
        myLights.SetActive(true);
    }

    public void PressNo(){
        HideUI();
    }

}
