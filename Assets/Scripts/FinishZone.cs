using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
}
}

   