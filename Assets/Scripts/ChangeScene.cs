using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{


    // Update is called once per frame
  
    public void scenceSwitch()
    {
        SceneManager.LoadScene("SampleScene");


    }

    public void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

  
}
