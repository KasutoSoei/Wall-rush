using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moovingwall : MonoBehaviour
{

    void Start(){
    }
    public float speed = 10;

    // Update is called once per frame
    void Update(){
        transform.Translate(new Vector3(0,0,1) * Time.deltaTime * speed);
    }
    


    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }

}
