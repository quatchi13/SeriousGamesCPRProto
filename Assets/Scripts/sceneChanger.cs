using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int sceneNumber;

    // Update is called once per frame
    public void ChangeScene(int sceneID){

        SceneManager.LoadScene (sceneBuildIndex: sceneID);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
