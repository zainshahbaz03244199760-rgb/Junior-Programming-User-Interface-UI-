using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 1.0f;
    private float xRange = 4;
    private float ySpawnPos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddForce(randomForce(), ForceMode.Impulse);
        targetRb.AddTorque(randomTorque(), randomTorque(), randomTorque(), ForceMode.Impulse);

        transform.position = randomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log("Delete object");
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    Vector3 randomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float randomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 randomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
