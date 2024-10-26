using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crochet : MonoBehaviour
{
    // Start is called before the first frame update
    public float torque = 250f;
    public float forceChariot = 500f;
    public float forceMoufle = 500f;
    public ArticulationBody moufle;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moufle.AddRelativeForce(transform.up * forceMoufle);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            moufle.AddRelativeForce(transform.up * -forceMoufle);
        }
    }
}
