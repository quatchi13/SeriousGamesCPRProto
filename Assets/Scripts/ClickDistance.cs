using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDistance : MonoBehaviour
{
    [SerializeField]
    private Transform hands;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(Vector3.Distance(hands.position, transform.position) < 2)
            {
                Debug.Log("target found");
            }
            else
            {
                Debug.Log("not close enough");
            }
        }
    }
}
