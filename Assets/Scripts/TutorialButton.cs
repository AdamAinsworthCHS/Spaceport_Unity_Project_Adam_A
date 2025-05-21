using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialButton : MonoBehaviour
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
        PlayerWeapons.weaponType = "Turret";
        PlayerController.speed = 5.0f;
        TutorialManager.tutorialStatus = 0;
        SceneManager.LoadScene("Tutorial");
    }
}
