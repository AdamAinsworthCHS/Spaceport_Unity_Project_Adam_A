using UnityEngine;

public class ShopManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public static int itemIdOne;
    public static int itemIdTwo;
    public static int itemIdThree;
    public static int weaponId;
    private static int weaponAvoid;

    void Awake()
    {
        itemIdOne = Random.Range(1, 5);
        itemIdTwo = Random.Range(1, 5);
        weaponId = Random.Range(1, 4);
        if (PlayerWeapons.weaponType == "MachineGun")
        {
            weaponAvoid = 1;
        }
        else if (PlayerWeapons.weaponType == "Turret")
        {
            weaponAvoid = 2;
        }
        else
        {
            weaponAvoid = 3;
        }

        while (itemIdTwo == itemIdOne)
        {
            itemIdTwo = Random.Range(1, 5);
        }
        itemIdThree = Random.Range(1, 5);
        while (itemIdThree == itemIdOne || itemIdThree == itemIdTwo)
        {
            itemIdThree = Random.Range(1, 5);
        }
        while (weaponId == weaponAvoid)
        {
            weaponId = Random.Range(1, 4);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
