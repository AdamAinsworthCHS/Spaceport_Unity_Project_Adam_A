using UnityEngine;
using UnityEngine.Audio;

public class PlayerWeapons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectile;
    public GameObject bigProjectile;
    public GameObject player;
    public static float damage = 1;
    private Vector3 offset = new Vector3(0, 0, 0);
    public static string weaponType = "Turret";
    public static float damageMult = 0;
    private float cooldown = 0;
    private float timeStamp = 0;
    private float soundTimeStamp = 0;
    public AudioClip laserSound;
    private AudioSource playerAudio;

    void Start()
    {
        if (weaponType == "MachineGun")
        {
            damageMult = 1f;
            cooldown = 0f;
        }
        if (weaponType == "Turret")
        {
            damageMult = 10f;
            cooldown = 0.07f;
        }
        if (weaponType == "Sniper")
        {
            damageMult = 16f;
            cooldown = 0.12f;
        }
        if (weaponType == "Cannon")
        {
            damageMult = 24f;
            cooldown = 0.3f;
        }
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            if (timeStamp <= Time.time)
            {
                GameObject clone;
                if (weaponType == "Cannon")
                {
                    clone = Instantiate(bigProjectile, player.transform.position + offset, player.transform.rotation);
                    if (soundTimeStamp <= Time.time)
                    {
                        playerAudio.pitch = (Random.Range(1f, 1.2f));
                        playerAudio.PlayOneShot(laserSound, 1.0f);
                        soundTimeStamp = Time.time + 0.07f;
                    }
                }
                else
                {
                    clone = Instantiate(projectile, player.transform.position + offset, player.transform.rotation);
                    if (soundTimeStamp <= Time.time)
                    {
                        playerAudio.pitch = (Random.Range(1f, 1.2f));
                        playerAudio.PlayOneShot(laserSound, 1.0f);
                        soundTimeStamp = Time.time + 0.07f;
                    }
                    
                }
                timeStamp = Time.time + cooldown;
            }
        }
    }
}