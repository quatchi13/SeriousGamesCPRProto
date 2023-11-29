using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTimer : MonoBehaviour
{
    private float intervalMin = 0.48f;
    private float intervalMax = 0.62f;
    public float timer = 0.0f;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetMouseButtonDown(0))
        {
            if (timer < intervalMin){
                Debug.Log("Slow down!");
            }
            else if (timer < intervalMax && timer > intervalMin){
                Debug.Log("Great work!");
            }
            else if (timer > intervalMax){
                Debug.Log("Hurry up!");
            }
            else{
                 Debug.Log("Oh Brother!");
            }
            timer = 0.0f;
        }
    }
}
