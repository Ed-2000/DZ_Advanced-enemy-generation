using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class EnemyRenderer : MonoBehaviour
{
    public void SetColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
