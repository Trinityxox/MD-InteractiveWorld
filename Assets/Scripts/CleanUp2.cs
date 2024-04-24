using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CleanUp2 : MonoBehaviour
{
    public GameObject ui;
    public PostProcessVolume blurredVision;
    Grain m_Grain;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
        m_Grain = blurredVision.sharedProfile.GetSetting<Grain>();
        m_Grain.active = true;
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
    Destroy(this.gameObject);
    m_Grain.intensity.Override(0.5f);


}

public void PressNo(){
    HideUI();
    m_Grain.intensity.Override(1f);


}

}
