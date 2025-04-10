using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
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
        PlayerHealth.maxShield = 100;
        PlayerHealth.maxHealth = 300;
        PlayerHealth.shield = PlayerHealth.maxShield;
        PlayerHealth.health = PlayerHealth.maxHealth;
        LevelManager.baseTime = 20;
        LevelManager.survivalTime = LevelManager.baseTime;
        EnemySpawning.spawnTime = 1.5f;
        PlayerWeapons.damage = 1;
        PlayerController.speed = 5.0f;
        SceneManager.LoadScene("SampleScene");
    }
}
