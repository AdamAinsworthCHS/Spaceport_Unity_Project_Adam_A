using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopExitButton : MonoBehaviour
{
    public Button button;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        PlayerHealth.health = PlayerHealth.maxHealth;
        PlayerHealth.shield = PlayerHealth.maxShield;
        if (LevelManager.baseTime < 100)
        {
            LevelManager.baseTime += 10;
        }
        LevelManager.survivalTime = LevelManager.baseTime;
        if (EnemySpawning.spawnTime > 0.7)
        {
            EnemySpawning.spawnTime -= 0.1f;
        }
        SceneManager.LoadScene("SampleScene");
    }
}
