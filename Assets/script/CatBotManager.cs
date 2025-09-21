// 19/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using System;
using UnityEditor;
using UnityEngine;

public class CatBotManager : MonoBehaviour
{
    // Variable to track the number of destroyed CatBots
    private int destroyedCatBots = 0;

    // Total number of CatBots to be destroyed before stopping the game
    [SerializeField] private int targetDestroyCount = 2;

    // Called whenever a CatBot is destroyed
    public void OnCatBotDestroyed()
    {
        destroyedCatBots++;

        // Check if the target number of destroyed CatBots has been reached
        if (destroyedCatBots >= targetDestroyCount)
        {
            StopGame();
        }
    }

    // Method to stop the game
    private void StopGame()
    {
        Debug.Log("All CatBots have been destroyed. Stopping the game...");
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop the game in the editor
        #else
        Application.Quit(); // Quit the game in a build
        #endif
    }
}
