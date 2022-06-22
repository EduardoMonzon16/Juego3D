
using UnityEngine;

[CreateAssetMenu(fileName ="Data", menuName ="ScriptableObjects/Enemy")]
public class EnemySO : ScriptableObject
{
    public string enemyName;
    public GameObject prefab;
    public float speed;

}
