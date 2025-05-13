using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopWeaponButtonText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ShopManager.weaponId == 1)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Machine Gun" + " for sale!";
        }
        else if (ShopManager.weaponId == 2)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Turret" + " for sale!";
        }
        else if (ShopManager.weaponId == 3)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Sniper" + " for sale!";
        }
        else
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Cannon" + " for sale!";
        }
    }
}
