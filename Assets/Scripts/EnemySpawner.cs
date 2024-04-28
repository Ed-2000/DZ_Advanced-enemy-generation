using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _spawnFrequency = 2;
    [SerializeField] private float _spawnStartTime = 0;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), _spawnStartTime, _spawnFrequency);
    }

    private void Spawn()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.GetComponent<EnemyMovement>().MoveStarter(_target.transform);
        enemy.GetComponent<EnemyRenderer>().SetColor(_color);
    }
}