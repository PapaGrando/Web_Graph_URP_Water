using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(-5f,0,0) * Time.deltaTime);
    }
}
