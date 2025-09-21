using UnityEngine;

public class GameEndManager : MonoBehaviour
{
    [Header("Prefabs à casser pour terminer le jeu")]
    public GameObject prefab1;
    public GameObject prefab2;
    
    [Header("UI de fin de jeu (optionnel)")]
    public GameObject gameEndUI;
    
    private bool prefab1Destroyed = false;
    private bool prefab2Destroyed = false;
    private bool gameEnded = false;
    
    private void Start()
    {
        // S'assurer que l'UI de fin est désactivée au début
        if (gameEndUI != null)
        {
            gameEndUI.SetActive(false);
        }
    }
    
    private void Update()
    {
        // Vérifier si les prefabs ont été détruits
        CheckPrefabsDestruction();
        
        // Si les deux sont détruits et le jeu n'est pas encore terminé
        if (prefab1Destroyed && prefab2Destroyed && !gameEnded)
        {
            EndGame();
        }
    }
    
    private void CheckPrefabsDestruction()
    {
        // Vérifier si le prefab1 existe encore
        if (prefab1 == null && !prefab1Destroyed)
        {
            prefab1Destroyed = true;
            Debug.Log("Prefab 1 détruit!");
        }
        
        // Vérifier si le prefab2 existe encore
        if (prefab2 == null && !prefab2Destroyed)
        {
            prefab2Destroyed = true;
            Debug.Log("Prefab 2 détruit!");
        }
    }
    
    private void EndGame()
    {
        gameEnded = true;
        Debug.Log("Jeu terminé! Les deux prefabs ont été détruits.");
        
        // Afficher l'UI de fin si disponible
        if (gameEndUI != null)
        {
            gameEndUI.SetActive(true);
        }
        
        // Arrêter le temps du jeu
        Time.timeScale = 0f;
        
        // Alternative: Quitter l'application (décommentez si nécessaire)
        // Application.Quit();
        
        // Alternative: Charger une scène de fin (décommentez et modifiez si nécessaire)
        // UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverScene");
    }
    
    // Méthode publique pour redémarrer le jeu
    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    
    // Méthode publique pour quitter le jeu
    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}