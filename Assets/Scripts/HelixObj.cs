using UnityEngine;

public class HelixObj : MonoBehaviour
{
    [SerializeField]
    GameObject[] segments;
    int gapStart;
    int gapLength;
    int dangerStart;
    int dangerLength;
    [SerializeField]
    Material damage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gapStart = Random.Range(0, 32);
        gapLength = Random.Range(3, 5);

        dangerLength = Random.Range(2, 5);
        dangerStart = ((Random.Range(0, 2) % 2 == 0) ? Random.Range(0, gapStart-gapLength) : Random.Range(gapStart + gapLength - 1, 32));
        if (dangerStart < 0) {
            dangerStart += 32;
        }
        for (int i = dangerStart; i < dangerStart+dangerLength; i++)
        {
            segments[i%32].GetComponent<MeshRenderer>().material = damage;
            segments[i % 32].tag = "Damage";
        }

        for (int i = gapStart; i < gapStart+gapLength; i++) {
            segments[i % 32].SetActive(false);
        }
    }

}
