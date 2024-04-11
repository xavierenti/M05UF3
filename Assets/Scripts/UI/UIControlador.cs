using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControlador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextScene(string screene)
    {
        SceneManager.LoadScene(screene);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
