using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstparkour : MonoBehaviour
{

    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,1) * Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider col){
        if(col.tag == "Player"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
