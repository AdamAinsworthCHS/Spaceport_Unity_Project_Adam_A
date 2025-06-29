using UnityEngine;
using UnityEngine.UI;

public class ShopWeaponButton : MonoBehaviour
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
            if (ShopManager.weaponId == 1)
            {
                PlayerWeapons.weaponType = "MachineGun";
            }
            else if (ShopManager.itemIdTwo == 2)
            {
                PlayerWeapons.weaponType = "Turret";
            }
            else if (ShopManager.itemIdThree == 3)
            {
                PlayerWeapons.weaponType = "Sniper";
            }
            else
            {
                PlayerWeapons.weaponType = "Cannon";
            }
            Destroy(gameObject);
        }
    }
}
