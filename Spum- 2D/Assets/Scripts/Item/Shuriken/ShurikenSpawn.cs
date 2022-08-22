
using Moments.Encoder;
using UnityEngine;

public class ShurikenSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Shuriken _shurikenPref;
    [SerializeField] private float _length = 3f;
    

    private void Start()
    {
        
    }

    public void InitShuriken(int count)
    {
        for (int i = 0; i < Inventory.Instance.suriken; i++)
        {
            GameObject shuriken = Instantiate(_shurikenPref.gameObject);
        }
    }
        
}
