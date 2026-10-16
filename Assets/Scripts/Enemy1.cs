using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    //fiende hastighet
    public float enemySpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //enemy rör sig neråt
        transform.Translate(Vector2.down * enemySpeed * Time.deltaTime);

        if (transform.position.y < -8)
        {
            this.transform.position = new Vector2(0, 6);
        }

    }
}
