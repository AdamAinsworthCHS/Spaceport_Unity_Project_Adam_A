using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject player;
    public GameObject enemy;
    public GameObject lightEnemy;
    public GameObject heavyEnemy;
    private int randomDecider;
    private int enemyType;
    private int xPos;
    private int yPos;
    private int zPos;
    private float timeStamp = 0;
    public static float spawnTime = 1.5f;
    private Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            GameObject clone;
            randomDecider = Random.Range(1, 3);
            if (randomDecider == 1)
            {
                xPos = Random.Range(10, 30);
                yPos = Random.Range(10, 30);
                zPos = Random.Range(10, 30);
            }
            else
            {
                xPos = Random.Range(-30, -10);
                yPos = Random.Range(-30, -10);
                zPos = Random.Range(-30, -10);
            }
            offset = new Vector3(xPos, yPos, zPos);
            enemyType = Random.Range(1, 4);
            if (enemyType == 1)
            {
                clone = Instantiate(enemy, player.transform.position + offset, player.transform.rotation);
            }
            else if (enemyType == 2)
            {
                clone = Instantiate(lightEnemy, player.transform.position + offset, player.transform.rotation);
            }
            else
            {
                clone = Instantiate(heavyEnemy, player.transform.position + offset, player.transform.rotation);
            }
                timeStamp = Time.time + spawnTime;
        }
    }
}
