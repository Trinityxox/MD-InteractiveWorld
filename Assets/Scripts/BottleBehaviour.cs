using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BottleBehaviour : MonoBehaviour
{
    public GameObject ui;
    public AudioClip drinkingWaterSound;
    public PostProcessVolume fuzzyVision;
    Vignette m_Vignette;
    // QuickVolume(int layer, float priority, params PostProcessEffectSettings[] settings);

// PostProcessVolume m_Volume;
//    Vignette m_Vignette

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
//fuzzyVision.
        // fuzzyVision.enabled = false;
      m_Vignette = fuzzyVision.sharedProfile.GetSetting<Vignette>();
      m_Vignette.active = false;

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
    Destroy(this.gameObject);
    GetComponent<AudioSource>().PlayOneShot(drinkingWaterSound);
    m_Vignette.active = false;

}
}
