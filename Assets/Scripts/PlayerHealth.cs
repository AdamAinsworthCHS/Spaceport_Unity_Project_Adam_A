using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float shield = 100;
    public float health = 300;
    public Material hurtMaterial;
    public Material shipMaterial;
    public Material shieldMaterial;
    private float timeStamp = 0;
    private float shieldTimeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (shield < 100)
        {
            if (shieldTimeStamp <= Time.time)
            {
                shield++;
                shieldTimeStamp = Time.time + 0.5f;
            }
        }
        if (timeStamp <= Time.time)
        {
            GetComponent<Renderer>().material = shipMaterial;
            timeStamp = Time.time + 0.1f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Enemy Projectile") == true)
        {
            if (shield <= 0)
            {
                health = health - 5;
                GetComponent<Renderer>().material = hurtMaterial;
            }
            else
            {
                shield = shield - 5;
                GetComponent<Renderer>().material = shieldMaterial;
            }
            
        }
    }
}
