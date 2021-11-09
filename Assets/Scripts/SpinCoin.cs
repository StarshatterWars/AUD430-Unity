using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCoin : MonoBehaviour
{
    //AudioSource m_PickupSound;
    //float rotationSpeed = 15f;
    
    void Start()
    {
        //m_PickupSound = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up, Space.World);
       //transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World); 
    }

    public void PlayPickupSound()
    {
        //m_PickupSound.Play();
    }
}
