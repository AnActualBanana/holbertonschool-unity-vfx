using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;
    // Start is called before the first frame update
    /// <summary>
    /// This function is called when the script is first loaded or when an object containing the script is enabled. 
    /// It instantiates 512 cubes and sets their position and rotation.
    /// </summary>
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 1000;
            _sampleCube[i] = _instanceSampleCube;
        }
    }

    // Update is called once per frame
    /// <summary>
    /// Called once per frame, updates the scale of the sample cubes based on the audio spectrum data.
    /// </summary>
    void Update()
    {
        //
        for (int i = 0; i < 512; i++)
        {
            if (_sampleCube != null)
            {
                _sampleCube[i].transform.localScale = new Vector3(10, (SpectrumAnalyzer._samplesLeft[i] * _maxScale) + 2, 10);
            }
        }
    }
}
