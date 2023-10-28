using UnityEngine;

public class generatePipesThatMoves : MonoBehaviour
{
    public GameObject pipes;
    public GameObject clouds;
    public float timerPipes = 0;
    public float delayPipes = 3;
    public float timerClouds = 0;
    public float delayClouds = 2;
    public int generatedPipes = 0;
    public GameObject finishGameScreen;
    public GameObject outsideBox;

    void Update()
    {
        if (generatedPipes == 2 )
        {
            Invoke("finishGame", 9);
            generatedPipes++;
        }
        else
        {
            if (timerPipes < delayPipes)
            {
                timerPipes += Time.deltaTime;
            }
            else if (generatedPipes < 2)
            {
                genPipes();
                timerPipes = 0;
            }
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
        Instantiate(pipes, new Vector3(Random.Range(rightLimiter, leftLimiter), transform.position.y, 0), transform.rotation);
        generatedPipes++;

    }

    public void genClouds()
    {
        float randomScaling = Random.Range(0.5f, 2.5f);

        GameObject newCloud = clouds;
        newCloud.transform.localScale = new Vector3(randomScaling, randomScaling, 1);

        Instantiate(newCloud, new Vector3(Random.Range(-30, 35), transform.position.y, 0), newCloud.transform.rotation);
    }

    private void finishGame()
    {
        if (fly.alive == true)
        {
            finishGameScreen.SetActive(true);
            outsideBox.SetActive(false);
        }
    }
}
