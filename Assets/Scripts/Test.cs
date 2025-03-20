using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody rb;
    public Vector3 angularV;
    public Vector3 turque;
    
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.angularVelocity = angularV;
        }
        
        else if (Input.GetMouseButton(2))
        {
            rb.AddTorque(turque);
        }
        else if (Input.GetKey(KeyCode.G))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
