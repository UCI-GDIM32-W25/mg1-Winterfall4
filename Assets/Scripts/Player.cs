using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.up * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * _speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsPlanted < 5)
        {
            Instantiate(_plantPrefab, _playerTransform.position, _playerTransform.rotation);
            _numSeedsPlanted++;
            _numSeedsLeft--;
        }
        
    }
}
