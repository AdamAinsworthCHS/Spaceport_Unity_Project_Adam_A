using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonThreeText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ShopManager.itemIdThree == 1)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Thruster Boost" + " for sale!";
        }
        else if (ShopManager.itemIdThree == 2)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Laser Concentrater" + " for sale!";
        }
        else if (ShopManager.itemIdThree == 3)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Shields Booster" + " for sale!";
        }
        else
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Hull Reinforcement" + " for sale!";
        }
    }
}
