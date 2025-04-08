using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyLookAtPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player_Ship");
        target = player.transform;
    }
    
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            transform.LookAt(target);
            timeStamp = Time.time + 1f;
            transform.Rotate(90, 0, 0);
        }

    }
}
