using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 velocityx, spin;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Kivk();
            
            //rb.interpolation
        }
        ApplyMagnusEffect();
    }

    void Kivk()
    {
        rb.linearVelocity = velocityx;
        rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce,ForceMode.Force);
    }
}
