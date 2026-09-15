using UnityEngine;

public class Point : MonoBehaviour
{
    public float point;
    public ObjectiveScript objectiveScript;
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Point"))
        {
            Destroy(collider.gameObject);
            point += 1;
        }
        if (collider.gameObject.CompareTag("Objective"))
        {
            objectiveScript.overallPoints += point;
            point = 0;
        }
    }
}
