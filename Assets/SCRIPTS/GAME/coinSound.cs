using UnityEngine;

public class coinSound : MonoBehaviour
{
    public logic logic2;
    public GameObject coinAudio;

    void Start()
    {
        logic2 = GameObject.FindGameObjectWithTag("LOGICA").GetComponent<logic>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            GameObject cloneAudio = Instantiate(coinAudio, transform.position, Quaternion.identity);
            logic2.destroyAudio(cloneAudio);
        }
    }
}
