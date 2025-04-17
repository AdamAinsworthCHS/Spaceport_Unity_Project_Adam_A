using UnityEngine;

public class EnemyHeavyWeapons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public GameObject projectile;
    public GameObject enemy;
    private Vector3 offset = new Vector3(0, 0, 0);
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            GameObject clone;
            clone = Instantiate(projectile, enemy.transform.position + offset, enemy.transform.rotation);
            timeStamp = Time.time + 1f;
        }
    }
}