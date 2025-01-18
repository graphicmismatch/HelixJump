using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody body;
    public float jumpF;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Damage")
        {
            Time.timeScale = 0;
            GameOver.endGame();
        }
        else {
            body.linearVelocity = Vector3.up * jumpF;
        }
    }
}
