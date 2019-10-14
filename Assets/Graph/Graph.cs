using UnityEngine;

public class Graph : MonoBehaviour
{
    public Transform pointPrefab;

    private void Awake()
    {
        Vector3 scale = Vector3.one / 5f;
        Vector3 position;
        position.z = 0f;
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x;
            point.localPosition = position;
            point.localScale = scale;
        }

    }
}
