using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatanionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Quaternion x = " + transform.rotation.x);
        Debug.Log("rotation angle x = " + transform.eulerAngles.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
