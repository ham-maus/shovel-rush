using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public Transform player;
    public float cameray = 5;
    public float cameray2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameray += Input.GetAxis("Mouse Y");
        cameray2 = -cameray;
        cameray2 = Mathf.Clamp(cameray2, -60, 60);

        Vector3 offset = -player.forward * 10 + Vector3.up * 5;
        transform.position = player.position + offset;
        transform.LookAt(player.position + Vector3.up * 2 + Vector3.down * cameray2); ;
    }
}
