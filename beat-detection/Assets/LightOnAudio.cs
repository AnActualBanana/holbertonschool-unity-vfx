using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnAudio : MonoBehaviour
{
    public int _band;
    public float _minIntensity, _maxIntensity;
    public float _fallOffRate = 0.99f;
    Light _light;

    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponent<Light>();
    }

    // Update is called once per frame

    void Update()
    {
    _light.intensity = (SpectrumAnalyzer._audioBandBuffer[_band] * (_maxIntensity - _minIntensity)) + _minIntensity * _fallOffRate;

    }
}
