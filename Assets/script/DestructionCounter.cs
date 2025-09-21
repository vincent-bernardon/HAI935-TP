using UnityEngine;

public static class DestructionCounter
{
    private static int totalDestructions = 0;
    
    public static int TotalDestructions
    {
        get { return totalDestructions; }
    }
    
    public static void AddDestruction()
    {
        totalDestructions++;
        Debug.Log("Total destructions globales: " + totalDestructions);
        
        // Vérifier si on doit arrêter le jeu
        if (totalDestructions >= 2)
        {
            EndGame();
        }
    }
    
    public static void ResetCount()
    {
        totalDestructions = 0;
        Debug.Log("Compteur de destructions remis à zéro");
    }
    
    private static void EndGame()
    {
        Debug.Log("Jeu terminé! " + totalDestructions + " objets détruits.");
        
        Application.Quit();
        
        // Pour le mode éditeur Unity
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}