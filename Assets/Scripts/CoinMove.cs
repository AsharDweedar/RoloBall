using UnityEngine;

public class CoinMove : MonoBehaviour
{
    public float yDeg = 1;
    public float rotationS = 100;
    void Start()
    {
        transform.Rotate(new Vector3(0, 1f, 0));
    }
    void Update()
    {
        float move = Mathf.Sin(Time.time);
        transform.position = new Vector3(transform.position.x, (move * 0.3f) + 0.6f, transform.position.z);
        transform.Rotate(new Vector3(0, (Time.deltaTime * (yDeg + 1) * rotationS) % 360, 0));

    }
}
