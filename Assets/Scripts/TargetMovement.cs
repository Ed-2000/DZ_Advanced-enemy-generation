using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;
    [SerializeField] private float _speed = 5;

    private int _targetPointIndex = 0;

    private void Update()
    {
        float minDistamce = 0.25f;

        if (Vector3.Distance(_points[_targetPointIndex].position, transform.position) <= minDistamce)
            _targetPointIndex = (_targetPointIndex + 1) % _points.Count;

        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _points[_targetPointIndex].position, _speed * Time.deltaTime);
    }
}