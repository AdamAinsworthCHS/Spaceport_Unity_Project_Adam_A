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

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Rotate(90, 0, 0);
    }
}
