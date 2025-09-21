// 21/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    public GameObject catBox1; // Assign the first CatBox prefab in the Inspector
    public GameObject catBox2; // Assign the second CatBox prefab in the Inspector

    private void Update()
    {
        // Check if both CatBoxes are destroyed
        if (catBox1 == null && catBox2 == null)
        {
            // Quit the application
            Debug.Log("Both CatBoxes are destroyed. Quitting the game...");
            Application.Quit();

            // For Editor mode (remove this line for build)
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}