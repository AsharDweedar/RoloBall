using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float CamHeight = 2;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        offset.y += CamHeight;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
