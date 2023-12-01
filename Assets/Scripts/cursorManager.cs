using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTex;
    private Vector2 cursorPoint;
    void Start()
    {
        cursorPoint = new Vector2(cursorTex.width/ 2, cursorTex.height / 2);
        Cursor.SetCursor(cursorTex, cursorPoint, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
