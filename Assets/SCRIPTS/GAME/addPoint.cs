using UnityEngine;

public class addPoint : MonoBehaviour
{
    public logic logic2;

    void Start()
    {
        logic2 = GameObject.FindGameObjectWithTag("LOGICA").GetComponent<logic>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) {
            logic2.addPoint();
            Destroy(gameObject);
        }
    }
}
