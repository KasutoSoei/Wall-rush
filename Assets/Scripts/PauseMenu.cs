using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool isPause;
    public GameObject PausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            if(isPause)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    void Pause(){
        Cursor.visible = true;
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        isPause = false;
    }

    public void Resume(){
        Cursor.visible = false;
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        isPause = true;
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
