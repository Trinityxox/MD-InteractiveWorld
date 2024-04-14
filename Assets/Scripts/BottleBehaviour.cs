using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleBehaviour : MonoBehaviour
{

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ShowUI();
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

public void PressDrink(){
    HideUI();
    myLight.enabled = !myLight.enabled;


}

public void PressOk(){
    HideUI();
}
}
