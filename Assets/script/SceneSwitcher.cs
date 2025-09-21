// 19/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Name of the scene to load
    [SerializeField] private string sceneName = "SampleScene";

    // Tag to identify the player
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding with this trigger has the specified player tag
        if (other.CompareTag(playerTag))
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
}