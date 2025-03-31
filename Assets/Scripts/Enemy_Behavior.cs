using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    
    void Start()
    {
        player = GameObject.Find("Player_Ship");
    }

    public float speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x + 10 || transform.position.y > player.transform.position.y + 10 || transform.position.z > player.transform.position.z + 10)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
