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
            Debug.Log("Up Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.up * _speed * Time.deltaTime);
            Debug.Log("Down Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
            Debug.Log("Right Arrow has been pressed");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * _speed * Time.deltaTime);
            Debug.Log("Left Arrow has been pressed");
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
            Debug.Log("Space Bar has been pressed");
            Debug.Log(_numSeedsLeft);
            Debug.Log(_numSeedsPlanted);
        }
        
    }
}
