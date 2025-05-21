using UnityEngine;
using UnityEngine.UI;

public class TutorialWeaponShopButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;

    void Start()
    {
        button.onClick.AddListener(TaskOnClick);
        LevelManager.money = 100;
        ShopManager.weaponId = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        if (LevelManager.money >= 100)
        {
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
