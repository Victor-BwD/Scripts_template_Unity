using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player move using rigidbody from Unity using AWSD or arrows, 

public class PlayerMoviment : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody rb;

    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xaxis = Input.GetAxis("Horizontal");
        float Zaxis = Input.GetAxis("Vertical");

        direction = new Vector3(Xaxis, 0, Zaxis);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + (direction * speed * Time.deltaTime)); // Move player from rigibody position
    }
}
