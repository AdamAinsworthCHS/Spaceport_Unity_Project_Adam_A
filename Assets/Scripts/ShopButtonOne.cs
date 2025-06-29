using UnityEngine;
using UnityEngine.UI;

public class ShopButtonOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;

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
        if (LevelManager.money >= 100)
        {
            MoneyText.playBuyAudio();
            LevelManager.money -= 100;
            if (ShopManager.itemIdOne == 1)
            {
                PlayerController.speed += 3;
            }
            else if (ShopManager.itemIdOne == 2)
            {
                PlayerWeapons.damage += 0.5f;
            }
            else if (ShopManager.itemIdOne == 3)
            {
                PlayerHealth.maxShield += 25;
            }
            else
            {
                PlayerHealth.maxHealth += 50;
            }
            Destroy(gameObject);
        }
    }
}
