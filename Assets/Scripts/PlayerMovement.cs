using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject laserShot;
    //variabel playerSpeed defineras
    public float playerSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.position = new Vector2(0, -4);
    }

    // Update is called once per frame
    void Update()
    {
        //Rörelse vänster
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }

        //Rörelse höger
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }

        //sjkuta laser uppåt
        if (Input.GetKey(KeyCode.Space)) 
        {
            Instantiate(laserShot, this.transform.position, Quaternion.identity);
        }

        //wraparound höger -> vänster
        if (transform.position.x > 8 )
        {
            this.transform.position = new Vector2(-8, -4);
        }

        //wraparound vänster -> höger
        if (transform.position.x < -8)
        {
            this.transform.position = new Vector2(8, -4);
        }
    }
}
