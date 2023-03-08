
using UnityEngine;

public class CameraFolowController : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerValue;


    void Start()
    {
        offset = transform.position - heroTransform.position;
    }

    
    void LateUpdate()
    {
        SetCameraSmoothFollow();

    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z)+offset, lerValue * Time.deltaTime);
        transform.position = newPosition;

    }

}
