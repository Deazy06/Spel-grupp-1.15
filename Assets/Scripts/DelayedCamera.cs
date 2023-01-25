using UnityEngine;

public class DelayedCamera : MonoBehaviour // Diyor (Delen som �r oaktiv var hittad p� UnityForums men jag gjordeom den s� att Y-axlen blev locked.)
{
    private Vector3 offset = new Vector3(0f, 3.85f, -10f);
    public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    public float yPostion = 1;

    [SerializeField] private Transform target;

    private void Update()
    {
       /* Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        */
        Vector3 pos = new Vector3(target.position.x, transform.position.y, transform.position.z) ;
        transform.position = pos;
    }


}