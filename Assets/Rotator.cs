using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 vector;

    private void Update() =>
        transform.Rotate(vector);
}