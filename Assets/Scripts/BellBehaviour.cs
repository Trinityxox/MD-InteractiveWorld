using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BellBehaviour : MonoBehaviour
    {
    public AudioClip DoorBellSound;
    public GameObject Burger;

    // Start is called before the first frame update
    void Start()
    {
        Burger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ding dong");
        GetComponent<AudioSource>().PlayOneShot(DoorBellSound);
        Burger.SetActive(true);



    }
    
}
