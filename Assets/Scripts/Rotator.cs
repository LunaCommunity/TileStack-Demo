using UnityEngine;

public class Rotator : MonoBehaviour
{
    public bool Rotate;
    public float Speed;

    private float angle;

    private void Update()
    {
        if (Rotate)
        {
            transform.rotation = Quaternion.AngleAxis(angle += Speed * Time.deltaTime, Vector3.up);
        }
    }
}
