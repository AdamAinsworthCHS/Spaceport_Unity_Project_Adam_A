using UnityEngine;

public class ShowMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public bool mouseShown = true;

    // Update is called once per frame
    void Update()
    {
        if (mouseShown == true)
        {
            Cursor.visible = true;
        }
    }
}
