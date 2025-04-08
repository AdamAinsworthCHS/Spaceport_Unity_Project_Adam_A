using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public GameObject player;
    public GameObject enemy;
    private int randomDecider;
    private int xPos;
    private int yPos;
    private int zPos;
    private float timeStamp = 0;
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
            clone = Instantiate(enemy, player.transform.position + offset, player.transform.rotation);
            timeStamp = Time.time + 1f;
        }
    }
}
