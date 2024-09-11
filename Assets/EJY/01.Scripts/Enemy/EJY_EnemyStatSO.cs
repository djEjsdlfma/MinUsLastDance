using UnityEngine;

[CreateAssetMenu(menuName = "SO/Enemy/StatData")]
public class EnemyStatSO : ScriptableObject
{
    public int level = 1;
    public float _hp;
    public int _damage;
    public int _speed;
}
