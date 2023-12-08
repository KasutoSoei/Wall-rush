using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
 
   public void playGame(){
        SceneManager.LoadScene(1);
    }

    public void level1 (){
        SceneManager.LoadScene(2);
        Cursor.visible = false;
    }
    public void level2 (){
        SceneManager.LoadScene(3);
        Cursor.visible = false;
    }

    public void level3 (){
        SceneManager.LoadScene(4);
        Cursor.visible = false;
    }

    public void returnmain(){
        SceneManager.LoadScene(0);
    }

    public void quitGame(){
        Application.Quit();
    }




}
