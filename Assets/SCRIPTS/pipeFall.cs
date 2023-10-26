using UnityEngine;

public class pipeFall : MonoBehaviour
{
    public int fallSpeed;
    public int destroyPipesPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ( Vector3.down * fallSpeed ) * Time.deltaTime;
        if(transform.position.y < destroyPipesPosition)
        {
            Destroy(gameObject);
        }
    }
}
