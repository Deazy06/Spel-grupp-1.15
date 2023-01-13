using UnityEngine;

public class DelayedCamera : MonoBehaviour
{
    private Vector3 offset = new Vector3(0f, 2f, -10f);
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    public float yPostion = 1;

    [SerializeField] private Transform target;

    private void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

    }


}