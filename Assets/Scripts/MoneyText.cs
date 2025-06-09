using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyText : MonoBehaviour
{
    private static AudioSource buyAudio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Money: " + "$" + LevelManager.money;
    }

    public static void playBuyAudio()
    {
        buyAudio.Play();
    }
}
