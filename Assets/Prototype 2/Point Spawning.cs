using UnityEngine;

public class PointSpawning : MonoBehaviour
{
    public GameObject gO;
    public float timer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 5;
        for (float i = 0; i < 3; i++)
        {
            Instantiate(gO, new Vector3(Random.Range(-10, 16), Random.Range(-4, 8), 0), Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void FixedUpdate()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(gO, new Vector3(Random.Range(-10, 16), Random.Range(-4, 8), 0), Quaternion.Euler(0, 0, 0));
            timer = 5;
        }
    }
}
