using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public Transform target;
    private float timeStamp = 0;

    // Update is called once per frame
    void Update()
    {
        if (timeStamp <= Time.time)
        {
            transform.LookAt(target);
            timeStamp = Time.time + 1f;
            transform.Rotate(90, 0, 0);
        }
        
    }
}
