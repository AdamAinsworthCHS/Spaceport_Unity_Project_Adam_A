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
    public float health = 100;
    public Material hurtMaterial;
    public Material shipMaterial;
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x + 10 || transform.position.y > player.transform.position.y + 10 || transform.position.z > player.transform.position.z + 10)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (health <= 0)
        {
            LevelManager.money += 25;
            Destroy(gameObject);
        }
        if (timeStamp <= Time.time)
        {
            GetComponent<Renderer>().material = shipMaterial;
            timeStamp = Time.time + 0.1f;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player Projectile") == true)
        {
            health -= PlayerWeapons.damage;
            GetComponent<Renderer>().material = hurtMaterial;
        }
    }
}
