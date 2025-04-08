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

    void Awake()
    {
        itemIdOne = Random.Range(1, 5);
        itemIdTwo = Random.Range(1, 5);
        while (itemIdTwo == itemIdOne)
        {
            itemIdTwo = Random.Range(1, 5);
        }
        itemIdThree = Random.Range(1, 5);
        while (itemIdThree == itemIdOne || itemIdThree == itemIdTwo)
        {
            itemIdThree = Random.Range(1, 5);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
