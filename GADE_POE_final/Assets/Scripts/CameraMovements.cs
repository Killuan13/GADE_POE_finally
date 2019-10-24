using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour
{
    [SerializeField] float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraMove();
        cameraZoom();
    }

    void cameraZoom()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime * 10, 0);
        }
    }

    void cameraMove()
    {
        float veritcal = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(speed * Time.deltaTime * horizontal, 0, speed * Time.deltaTime * veritcal);
    }
}
