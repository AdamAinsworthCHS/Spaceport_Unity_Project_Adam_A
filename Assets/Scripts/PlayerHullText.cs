using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerHealthText : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    [SerializeField]
    private TextMeshPro TMP;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Hull: " + PlayerHealth.health;
    }
}
