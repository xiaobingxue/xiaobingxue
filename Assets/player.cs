using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody rd;
    
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);

        }
    }
}
