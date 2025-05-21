using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    public static int tutorialStatus = 0;
    private Vector3 mousePos;
    private bool enemySpawned = false;
    GameObject clone;
    public GameObject enemy;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (tutorialStatus == 0)
        {
            if (mousePos != Input.mousePosition)
            {
                tutorialStatus = 1;
                enemySpawned = false;
            }
        }
        if (tutorialStatus == 1)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                tutorialStatus = 2;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                tutorialStatus = 2;
            }
        }
        if (tutorialStatus == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                tutorialStatus = 3;
            }
        }
        if (tutorialStatus == 3)
        {
            if (enemySpawned == false)
            {
                clone = Instantiate(enemy, player.transform.position + new Vector3(0, 0, 10), player.transform.rotation);
                enemySpawned = true;
            }
            
            if (LevelManager.money > 0)
            {
                tutorialStatus = 4;
            }
        }
        if (tutorialStatus == 4)
        {
            enemySpawned = false;
            SceneManager.LoadScene("TutorialShop");
        }
        if (tutorialStatus == 5)
        {
            if (enemySpawned == false)
            {
                clone = Instantiate(enemy, player.transform.position + new Vector3(0, 0, 10), player.transform.rotation);
                clone = Instantiate(enemy, player.transform.position + new Vector3(0, 10, 0), player.transform.rotation);
                clone = Instantiate(enemy, player.transform.position + new Vector3(10, 0, 10), player.transform.rotation);
                clone = Instantiate(enemy, player.transform.position + new Vector3(0, -10, 0), player.transform.rotation);
                enemySpawned = true;
            }

            if (LevelManager.money >= 100)
            {
                SceneManager.LoadScene("TitleScreen");
            }
        }
    }
}
