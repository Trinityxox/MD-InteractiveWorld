using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BottleBehaviour : MonoBehaviour
{
    public GameObject ui;
    public AudioClip drinkingWater;
    public PostProcessVolume fuzzyVision;
    Vignette m_Vignette;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
      m_Vignette = fuzzyVision.sharedProfile.GetSetting<Vignette>();
      m_Vignette.active = true;

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
    
    AudioSource audioSource = GetComponent<AudioSource>();

    // Ensure that the AudioSource is enabled temporarily
    bool wasAudioSourceEnabled = audioSource.enabled;
    audioSource.enabled = true;

    // Play the audio clip
    audioSource.PlayOneShot(drinkingWater);

    // Restore the original enabled state of the AudioSource
    audioSource.enabled = wasAudioSourceEnabled;
    
    m_Vignette.active = false;

}
}
