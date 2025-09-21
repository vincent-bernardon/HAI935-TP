using System;
using UnityEditor;
using UnityEngine;
public class Destructible : MonoBehaviour
{
    public GameObject destructible;
    public AudioClip destructionSound;
    private AudioSource audioSource; 

    private void Start()
    {
        // Obtenir ou ajouter un composant AudioSource
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Jouer le bruitage de destruction si disponible
            if (destructionSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(destructionSound);
            }
            
            Destroy(destructible);
            
            // Incrémenter le compteur global de destructions
            DestructionCounter.AddDestruction();
        }
    }
private void AttachToPlayer (Transform player) { //suggerée par l’IA
    transform.SetParent(player);
    transform.localPosition = new Vector3(0,0.7f,0); //ajustez la position selon votre scène
    transform.localRotation = Quaternion.identity;
    }
}