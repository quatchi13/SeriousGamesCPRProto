using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDistance : MonoBehaviour
{
    [SerializeField]
    private Transform hands;
    private Vector2 mousePos;
    public GameObject green;
    public GameObject red;
    public GameObject gray;

    // Update is called once per frame

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButtonDown(0))
        {
            gray.SetActive(false);
            if(Vector3.Distance(transform.position, mousePos) < 0.25)
            {
                Debug.Log("target found");
                green.SetActive(true);
                red.SetActive(false);
            }
            else
            {
                Debug.Log("not close enough");
                red.SetActive(true);
                green.SetActive(false);

            }
        }
    }
}
