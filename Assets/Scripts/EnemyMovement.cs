using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;

    public void MoveStarter(Transform target)
    {
        StartCoroutine(Move(target));
    }

    private IEnumerator Move(Transform target)
    {
        var wait = new WaitForEndOfFrame();

        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
            yield return wait;
        }
    }
}