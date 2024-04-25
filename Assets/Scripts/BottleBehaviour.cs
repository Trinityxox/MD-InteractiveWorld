using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BottleBehaviour : MonoBehaviour
{
    public GameObject ui;
    public AudioClip drinkingWater;
    public AudioSource soundSource;
    public GameObject ui2;
    public PostProcessVolume fuzzyVision;
    Vignette m_Vignette;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
      m_Vignette = fuzzyVision.sharedProfile.GetSetting<Vignette>();
      m_Vignette.active = true;
      HideUI2();

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

public void HideUI2(){
ui2.SetActive(false);
Cursor.lockState = CursorLockMode.Locked;
Cursor.visible = false;
}

public void ShowUI2(){
ui2.SetActive(true);
Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;
}

public void PressDrink(){
    HideUI();
    Destroy(this.gameObject);

if (!soundSource.isPlaying)
        {
            soundSource.clip = drinkingWater;
            soundSource.Play();
        }
    
    m_Vignette.active = false;
    
ShowUI2();
}
}
