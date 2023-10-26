using UnityEngine;

public class generatePipes : MonoBehaviour
{
    public GameObject pipes;
    public float timer = 4;
    public float delay = 4;

    void Start()
    {
        genPipes();
    }

    void Update()
    {
        if (timer < delay)
        {
            timer += Time.deltaTime;
        } 
        else
        {
            genPipes();
            timer = 0;
        }
    }

    public void genPipes()
    {
        int aux = 10;
        float rightLimiter = transform.position.x + aux;
        float leftLimiter = transform.position.x - aux;
        Instantiate(pipes, new Vector3(Random.Range(rightLimiter, leftLimiter), transform.position.y, 0) , transform.rotation);
    }
}
