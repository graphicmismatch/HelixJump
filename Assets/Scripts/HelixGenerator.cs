using UnityEngine;

public class HelixGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatforms = 20;
    public float platformSpacing = 3f;
    public static HelixGenerator hg;
    void Start()
    {
        hg = this;
        numberOfPlatforms = Random.Range(10, 30);
        GenerateHelix();
    }

    void GenerateHelix()
    {
        float yPos = 0;

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            GameObject platform = Instantiate(platformPrefab, transform);
            platform.transform.position = new Vector3(0, yPos, 0);
           // platform.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0); 
            yPos -= platformSpacing;
        }
    }
}
