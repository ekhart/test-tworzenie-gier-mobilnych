using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 vector;

    void Update()
    {
        transform.Rotate(vector);
    }
}
