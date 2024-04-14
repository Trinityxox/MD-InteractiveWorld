using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBehaviour : MonoBehaviour
{

    public GameObject ui;

    Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

           private void OnTriggerEnter(Collider other){
            Debug.Log("let there be light");
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
    myLight.enabled = myLight.enabled;

}

public void PressNo(){
    HideUI();
}

}
