using UnityEngine;

public class Move : MonoBehaviour
{
    private float _speedMove = 0.05f;

    private void Update()
    {
        var nextPosition = transform.position;
        nextPosition.z += _speedMove;
        transform.position = nextPosition;
    }
}
