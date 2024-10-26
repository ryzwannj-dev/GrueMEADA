using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    float velocity = 0.09f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * velocity/10);
            Debug.Log("pressed");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * velocity/10);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward, velocity*10);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back, velocity*10);
        }

        //bras articuler de la grue mobile
        /* 
        Gauche avant 135*
        Droite avant -135*
        Gauche arriere -135*
        Droite arriere 135*        
        */

    }
}