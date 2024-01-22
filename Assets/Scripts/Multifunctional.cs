using UnityEngine;

public class Multifunctional : MonoBehaviour
{
    private void Update()
    {
        Move();
        Rotate();
        Scale();
    }

    private void Move()
    {
        var nextPosition = transform.position;
        nextPosition.z += 0.05f;
        transform.position = nextPosition;
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, 10f * Time.deltaTime);
    }

    private void Scale()
    {
        this.transform.localScale = this.transform.localScale + new Vector3(1f,1f,1f) * Time.deltaTime;
    }
}
