using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public GameObject player;
    
    void Start()
    {
        transform.Rotate(90, 0, 0);
        player = GameObject.Find("Player_Ship");
    }

    public float speed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (speed * -1));
        
        if (transform.position.x > player.transform.position.x + 100 || transform.position.y > player.transform.position.y + 100 || transform.position.z > player.transform.position.z + 100 || transform.position.x < player.transform.position.x - 100 || transform.position.y < player.transform.position.y - 100 || transform.position.z < player.transform.position.z - 100)
        {
            Destroy(gameObject);
        }
    }
}
