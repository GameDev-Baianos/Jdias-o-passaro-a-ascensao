using UnityEngine;

public class pipeFall : MonoBehaviour
{
    public int fallSpeed;
    public int destroyPipesPosition;

    void Update()
    {
        transform.position = transform.position + ( Vector3.down * fallSpeed ) * Time.deltaTime;
        if(transform.position.y < destroyPipesPosition)
        {
            Destroy(gameObject);
        }
    }
}
