using System;
using UnityEngine;

public class fly : MonoBehaviour
{
    public Rigidbody2D rb;
    public int flyStrength;
    public int sideMoveStrength;
    public logic logic2;
    public bool alive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic2 = GameObject.FindGameObjectWithTag("LOGICA").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive)
        {
            if (Input.GetKeyDown(KeyCode.Space)) { 
                rb.velocity = Vector2.up * flyStrength;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity = rb.velocity + Vector2.left * sideMoveStrength;
                gameObject.transform.localScale = new Vector3(-1, 1, 1);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity = rb.velocity + Vector2.right * sideMoveStrength;
                gameObject.transform.localScale = new Vector3(1, 1, 1);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        alive = false;
        logic2.gameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MORRA")
        {
            alive = false;
            logic2.gameOver();
        }
    }
}
