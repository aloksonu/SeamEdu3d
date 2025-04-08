using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private bool started;
    private bool gameOver;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started) {
            rb.velocity = new Vector3(speed, 0, 0);
            started = true;
        }

        Debug.DrawRay(this.transform.position, Vector3.down, Color.red);

        if(!Physics.Raycast(this.transform.position, Vector3.down, 1)){
            gameOver = true;
            rb.velocity = new Vector3(0,-25,0);
            Camera.main.GetComponent<CameraFollow>().gameOver = gameOver;
        }

        if (Input.GetMouseButtonDown(0) && !gameOver) {
            SwitchDirection();
        } 
    }

   private void SwitchDirection()
{
    if (rb.velocity.z < 0)
    {
        rb.velocity = new Vector3(speed, 0, 0); // Move in -X
    }
    else if (rb.velocity.x < 0)
    {
        rb.velocity = new Vector3(0, 0, speed); // Move in -Z
    }
}
}
