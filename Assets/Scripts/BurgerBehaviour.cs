using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BurgerBehaviour : MonoBehaviour
{
    public GameObject ui;
    public GameObject Burger;
    public PostProcessVolume blurredVision;
    Grain m_Grain;
    public GameObject Tv;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
        HideTv();
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
            public void HideTv(){
        Tv.SetActive(false);
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;
    }

    public void ShowTv(){
        Tv.SetActive(true);
        // Cursor.lockState = CursorLockMode.None;
        // Cursor.visible = true;
    }

    public void PressYes(){
        HideUI();
        Burger.SetActive(false);
        ShowTv();
    m_Grain.intensity.Override(0f);
    }

    public void PressNo(){
        HideUI();
    }
}
