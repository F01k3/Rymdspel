using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    //variabel laserSpeed defineras
    public float laserSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rörelse uppåt
            transform.Translate(Vector2.up * laserSpeed * Time.deltaTime);
    }
}
