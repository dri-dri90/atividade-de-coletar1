using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int velocidade = 10;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(message: "START");
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "UPDATE");
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x: h, y: 0, z: v);
        rb.AddForce(direction * velocidade);
    }
}
