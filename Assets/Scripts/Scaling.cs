using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale *= _speed;
    }
}
