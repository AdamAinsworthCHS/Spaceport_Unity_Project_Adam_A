using UnityEngine;

public class TitleEnemyEasterEgg : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;

    void Start()
    {
        
    }

    public float health = 100;
    public Material hurtMaterial;
    public Material shipMaterial;
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
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
            health -= PlayerWeapons.damage * PlayerWeapons.damageMult;
            GetComponent<Renderer>().material = hurtMaterial;
        }
    }
}
