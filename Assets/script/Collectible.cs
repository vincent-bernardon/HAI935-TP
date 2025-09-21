using System;
using UnityEditor;
using UnityEngine;
public class Collectible : MonoBehaviour
{

 private void OnTriggerEnter(Collider other) {
 if (other.CompareTag("Player")) {
 AttachToPlayer(other.transform);
 }
 }
 private void AttachToPlayer (Transform player) { //suggerée par l’IA
transform.SetParent(player);
transform.localPosition = new Vector3(0,0.7f,0); //ajustez la position selon votre scène
transform.localRotation = Quaternion.identity;
 }
}