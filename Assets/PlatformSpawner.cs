using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    [SerializeField] private int levelLenght;
    private float deltaTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitialSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime = Time.deltaTime;
    }

    void InitialSpawn()
    {
        for (int i = 0; i < levelLenght; i++)
        {
            Instantiate(platform, new Vector3(i * 20, 0, 0), Quaternion.Euler(Vector3.zero));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Instantiate(platform, new Vector3(other.transform.position.x + (levelLenght * 20), 0, 0), Quaternion.Euler(Vector3.zero));
        Destroy(other.gameObject);
    }
}
