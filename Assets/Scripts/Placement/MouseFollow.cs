using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class MouseFollow : MonoBehaviour
{
    private Vector2 mousePosition;
    // Update is called once per frame
    void Update()
    {
         mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;

    }
}
