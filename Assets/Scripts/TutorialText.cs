using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (TutorialManager.tutorialStatus == 0)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Use the mouse to look around";
        }
        if (TutorialManager.tutorialStatus == 1)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Use W or S to move";
        }
        if (TutorialManager.tutorialStatus == 2)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Press SPACE to shoot";
        }
        if (TutorialManager.tutorialStatus == 3)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Defeat this enemy. Watch out for red lasers!";
        }
        if (TutorialManager.tutorialStatus == 5)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Defeat these enemies to complete the tutorial!";
        }
    }
}
