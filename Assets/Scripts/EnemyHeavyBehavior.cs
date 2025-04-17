using UnityEngine;

public class EnemyHeavyBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Player_Ship");
    }

    public float speed = 1.0f;
    public float health = 200;
    public Material hurtMaterial;
    public Material shipMaterial;
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x + 4 || transform.position.y > player.transform.position.y + 4 || transform.position.z > player.transform.position.z + 4 || transform.position.x < player.transform.position.x - 4 || transform.position.y < player.transform.position.y - 4 || transform.position.z < player.transform.position.z - 4)
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
