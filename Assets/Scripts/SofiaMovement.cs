using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SofiaMovement : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.transform.position.x -3, target.transform.position.y +1, target.transform.position.z);
    }
}
