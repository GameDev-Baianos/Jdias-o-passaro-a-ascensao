using TMPro;
using UnityEngine;

public class pipeSideMovement : MonoBehaviour
{
    public int movementSpeed;
    public TextMeshProUGUI points;

    private void Start()
    {
        movementSpeed = Random.Range(1, 6);
        Invoke("changeDirection", 3);
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.right * movementSpeed) * Time.deltaTime;
    }

    public void changeDirection()
    {
        movementSpeed = movementSpeed - ( movementSpeed * 2 );
        Invoke("changeDirection", 3);
    }
}