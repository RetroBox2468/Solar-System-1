using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //declaring variable to select rotation target
    public Transform target;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate Around first parameter target position
        // Rotate Around needs second parameter about axis or rotation
        // Rotate Around third parameter needed is speed of rotation
        transform.RotateAround(target.transform.position, target.transform.up, speed *Time.deltaTime);
        
    }
}
