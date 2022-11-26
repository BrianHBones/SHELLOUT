using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingClip;
    [SerializeField] [Range(0f, 1f)]float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip damageClip;
    [SerializeField] [Range(0f, 1f)]float damageVolume = 1f;

    [Header("Death")]
    [SerializeField] AudioClip deathClip;
    [SerializeField] [Range(0f, 1f)]float deathVolume = 1f;

    [Header("Menu")]
    [SerializeField] AudioClip selectClip;
    [SerializeField] [Range(0f, 1f)]float selectVolume = 1f;

    public void PlayShootingClip(){
        if(shootingClip != null){
            AudioSource.PlayClipAtPoint(shootingClip, Camera.main.transform.position, shootingVolume);
        }
    }
    
    public void PlayDamageClip(){
        if(damageClip != null){
            AudioSource.PlayClipAtPoint(damageClip, Camera.main.transform.position, damageVolume);
        }
    }
    
    public void PlayDeathClip(){
        if(deathClip != null){
            AudioSource.PlayClipAtPoint(deathClip, Camera.main.transform.position, deathVolume);
        }
    }

    public void PlayMenuSelectClip(){
        if(selectClip != null){
            AudioSource.PlayClipAtPoint(selectClip, Camera.main.transform.position, selectVolume);
        }
    }
}
