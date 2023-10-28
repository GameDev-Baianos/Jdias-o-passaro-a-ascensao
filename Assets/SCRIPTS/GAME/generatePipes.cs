using UnityEngine;

public class generatePipes : MonoBehaviour
{
    public GameObject pipes;
    public GameObject clouds;
    public GameObject nextGenerator;
    public float timerPipes = 0;
    public float delayPipes = 3;
    public float timerClouds = 0;
    public float delayClouds = 4;
    public float generatedPipes = 0;

    private void Start()
    {
        genPipes();
    }

    void Update()
    {
        if (timerPipes < delayPipes)
        {
            timerPipes += Time.deltaTime;
        }
        else
        {
            genPipes();
            timerPipes = 0;
        }
        if (timerClouds < delayClouds)
        {
            timerClouds += Time.deltaTime;
        }
        else
        {
            genClouds();
            timerClouds = 0;
            delayClouds = Random.Range(1, 6);
        }

    }

    public void genPipes()
    {
        int aux = 10;
        float rightLimiter = transform.position.x + aux;
        float leftLimiter = transform.position.x - aux;
        Instantiate(pipes, new Vector3(Random.Range(rightLimiter, leftLimiter), transform.position.y, 0) , transform.rotation);
        generatedPipes += 1;
        if(generatedPipes == 10)
        {
            nextGenerator.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void genClouds()
    {
        float randomScaling = Random.Range(0.5f, 2.5f);

        GameObject newCloud = clouds;
        newCloud.transform.localScale = new Vector3(randomScaling, randomScaling, 1);

        Instantiate(newCloud, new Vector3(Random.Range(-30, 35), transform.position.y, 0), newCloud.transform.rotation);
    }
}
