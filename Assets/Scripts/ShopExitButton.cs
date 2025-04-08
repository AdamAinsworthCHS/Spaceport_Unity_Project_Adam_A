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
        LevelManager.survival_time = 20;
        SceneManager.LoadScene("SampleScene");
    }
}
