using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        this.transform.localScale = this.transform.localScale + new Vector3(1f,1f,1f) * _speed * Time.deltaTime;
    }
}
