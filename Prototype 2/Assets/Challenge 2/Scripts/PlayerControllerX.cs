using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject projectilePrefab;

    bool possible = true;
    
    float delayTime = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(possible == true)
            {
            // set possible to "false" to not send dog
            possible = false;
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Invoke("ResetPossible", delayTime);
            }
        }
    }
    void ResetPossible()
    {
        possible = true; 
    }
}
