using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class logic : MonoBehaviour
{
    public TextMeshProUGUI canvas;
    public int score;
    public GameObject screen;

    public void addPoint(int howMany)
    {
        score += howMany;
        canvas.text = score.ToString();
    }

    public void destroyAudio(GameObject audio) {
        Destroy(audio.gameObject, 1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void restartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        screen.SetActive(true);
    }
}
