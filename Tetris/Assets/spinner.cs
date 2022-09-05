using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // private Vector3 rotateAmount = new Vector3(x: 0, y: 0, z: -200);
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(rotateAmount * Time.deltaTime, Space.World);
        pos = transform.localPosition;
        pos.x += Input.GetAxis("Horizontal") * Time.deltaTime * 20;
        pos.y += Input.GetAxis("Vertical") * Time.deltaTime * 20;
        transform.localPosition = pos;
    }
}
