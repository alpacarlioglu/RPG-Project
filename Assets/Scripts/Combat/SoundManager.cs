using System.Collections;
using System.Collections.Generic;
using RPG.Core;
using UnityEngine;

public class SoundManager : MonoBehaviour
{ 
    [SerializeField] private AudioSource deathSound;
    
    void Start()
    {
        GetComponent<AudioClip>();
        Health.OnDeath += PlaySound;
    }
    void PlaySound()
    {
        deathSound.Play();
    }

    
}
