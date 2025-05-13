using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject projectile;
    public GameObject player;
    public static float damage = 1;
    private Vector3 offset = new Vector3(0, 0, 0);
    public static string weaponType = "Turret";
    public static float damageMult = 0;
    private float cooldown = 0;
    private float timeStamp = 0;

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
        print(damage);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            if (timeStamp <= Time.time)
            {
                GameObject clone;
                clone = Instantiate(projectile, player.transform.position + offset, player.transform.rotation);
                timeStamp = Time.time + cooldown;
            }
        }
    }
}
