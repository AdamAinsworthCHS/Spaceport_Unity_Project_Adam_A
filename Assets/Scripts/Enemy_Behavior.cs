using UnityEngine;

public class Enemy_Behavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 2.0f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Rotate(90, 0, 0);
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
