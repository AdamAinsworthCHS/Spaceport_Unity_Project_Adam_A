using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static float level = 1;
    public static float money = 0;
    public static float survivalTime = 20;
    public static float baseTime = 20;
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            survivalTime--;
            timeStamp = Time.time + 1f;
        }

        if (survivalTime <= 0)
        {
            level++;
            SceneManager.LoadScene("Shop");
        }
    }
}
