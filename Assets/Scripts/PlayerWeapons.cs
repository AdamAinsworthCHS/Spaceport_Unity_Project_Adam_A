using UnityEngine;

public class PlayerWeapons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public GameObject projectile;
    public GameObject player;
    private Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            {
                GameObject clone;
                clone = Instantiate(projectile, player.transform.position + offset, player.transform.rotation);
            }
        }
    }
}
