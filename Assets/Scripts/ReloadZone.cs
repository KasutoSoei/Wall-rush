using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadZone : MonoBehaviour
{

    public void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            }
        }
}
 

