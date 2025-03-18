using UnityEngine;

public class HideMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public bool mouseHidden = true;

    // Update is called once per frame
    void Update()
    {
        if (mouseHidden == true)
        {
            Cursor.visible = false;
        }
    }
}
