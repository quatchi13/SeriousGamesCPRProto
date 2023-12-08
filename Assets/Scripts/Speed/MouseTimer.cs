using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTimer : MonoBehaviour
{
    private float intervalMin = 0.48f;
    private float intervalMax = 0.62f;
    public float timer = 0.0f;
    public GameObject green;
    public GameObject yellow;
    public GameObject red;
    public GameObject gray;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            gray.SetActive(false);
            if (timer < intervalMin){
                Debug.Log("Slow down!");
                green.SetActive(false);
                red.SetActive(false);
                yellow.SetActive(true);
            }
            else if (timer < intervalMax && timer > intervalMin){
                Debug.Log("Great work!");
                green.SetActive(true);
                red.SetActive(false);
                yellow.SetActive(false);
            }
            else if (timer > intervalMax){
                Debug.Log("Hurry up!");
                green.SetActive(false);
                red.SetActive(true);
                yellow.SetActive(false);
            }
            else{
                 Debug.Log("Oh Brother!");
            }
            timer = 0.0f;
        }
    }
}
