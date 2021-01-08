using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timeout = 2f; // set here the time
     private float waitTime = 2f;

    // Update is called once per frame
    void Update()
    {
        //Increase every frame
        waitTime -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (waitTime < 0))
        {        
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // reset time 
            waitTime = timeout;
        }
    }
}
