using UnityEngine;

public class Multifunctional : MonoBehaviour
{
    private float _speedMove = 0.05f;
    private float _speedRotate = 12f;

    private void Update()
    {
        Move();
        Rotate();
        Scale();
    }

    private void Move()
    {
        var nextPosition = transform.position;
        nextPosition.z += _speedMove;
        transform.position = nextPosition;
    }

    private void Rotate()
    {
        transform.RotateAround(transform.position, Vector3.up, _speedRotate * Time.deltaTime);
    }

    private void Scale()
    {
        this.transform.localScale = this.transform.localScale + new Vector3(1f,1f,1f) * Time.deltaTime;
    }
}
