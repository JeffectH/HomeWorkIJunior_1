using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private GameObject _cubeOne;
    [SerializeField] private float _speedRotate;
    [Space]
    [SerializeField] private GameObject _cubeTwo;
    [Space]
    [SerializeField] private GameObject _sphere;
    [SerializeField] private float _speedMove;
    [Space]
    [SerializeField] private GameObject _capsule;
    [SerializeField] private float _speedScale;


    private void Update()
    {
        _sphere.transform.Translate(_sphere.transform.forward * _speedMove * Time.deltaTime);

        _cubeOne.transform.Rotate(_cubeOne.transform.up * _speedRotate * Time.deltaTime);

        _capsule.transform.localScale *= _speedScale;

        _cubeTwo.transform.Translate(_cubeTwo.transform.forward * _speedMove * Time.deltaTime);
        _cubeTwo.transform.Rotate(_cubeTwo.transform.up * _speedRotate * Time.deltaTime);
        _cubeTwo.transform.localScale *= _speedScale;
    }
}
