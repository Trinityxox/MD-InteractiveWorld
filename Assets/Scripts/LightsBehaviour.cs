using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBehaviour : MonoBehaviour
{

    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
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
}

public void ShowUI(){
ui.SetActive(true);
}

}
