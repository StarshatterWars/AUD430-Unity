using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    AudioSource m_ExplosionSound;
    Vector3 spawnPlayer;
    public GameObject explosion;
    // Constructor lab 3//
    GUIStyle bigFont;
    Backpack backpack = new Backpack();
    ///////////////////////////////////
    // lab 4 //
    GUIStyle lostCoin;

    // Start is called before the first frame update
    void Start()
    {
        spawnPlayer = transform.position;
        // lab 3 //
        m_ExplosionSound = GetComponent<AudioSource>();
        bigFont = new GUIStyle();
        bigFont.normal.textColor = new Color(255, 255, 255);
        bigFont.fontSize = 30;
        ////////////////////////////////////
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Enemy")
        {
            RespawnPlayer(); 
        }
    }

    void RespawnPlayer() 
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        transform.position = spawnPlayer;
        m_ExplosionSound.Play();
    }

    // lab 3 //
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Coin")
        {
            backpack.AddToBackpack();
            other.gameObject.GetComponent<SpinCoin>().PlayPickupSound();
            Destroy(other.gameObject);
        }
    }

    
    void OnGUI() 
    {
        GUI.Label(new Rect(100, 50, 200, 100), "POINTS: " + backpack.itemCount, bigFont);
    }
    ////////////////////////////////////////////////////
}
