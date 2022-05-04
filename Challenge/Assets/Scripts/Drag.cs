using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{

    private bool startDrag;
    private Vector3 prevPos = Vector3.zero;
    private Vector3 difPos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            difPos = Input.mousePosition - prevPos;
            transform.Rotate(new Vector3(0, 0, -difPos.x), Space.Self);
        }

        prevPos = Input.mousePosition;
    }

}
