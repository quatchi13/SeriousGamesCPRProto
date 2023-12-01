using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int sceneNumber;

    // Update is called once per frame
    void Update()
    {
        void OnMouseDown(){
            SceneManager.LoadScene (sceneBuildIndex: sceneNumber);
        }
    }
}
