using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOnAmplitude : MonoBehaviour
{
    public float _startScale, _maxScale;
    public bool _useBuffer;
    Material _material;
    public float _red, _green, _blue;
    // Start is called before the first frame update
    void Start()
    {
        _material = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (!_useBuffer && SpectrumAnalyzer._amplitude > 0)
        {
            transform.localScale = new Vector3 ((SpectrumAnalyzer._amplitude * _maxScale) + _startScale, (SpectrumAnalyzer._amplitude * _maxScale) + _startScale, (SpectrumAnalyzer._amplitude * _maxScale) + _startScale);
            Color _color = new Color(_red * SpectrumAnalyzer._amplitude, _green * SpectrumAnalyzer._amplitude, _blue * SpectrumAnalyzer._amplitude);
            _material.SetColor("_EmissionColor", _color);
        }
        if (_useBuffer && SpectrumAnalyzer._amplitude> 0)
        {
            transform.localScale = new Vector3 ((SpectrumAnalyzer._amplitudeBuffer * _maxScale) + _startScale, (SpectrumAnalyzer._amplitudeBuffer * _maxScale) + _startScale, (SpectrumAnalyzer._amplitudeBuffer * _maxScale) + _startScale);
            Color _color = new Color(_red * SpectrumAnalyzer._amplitudeBuffer, _green * SpectrumAnalyzer._amplitudeBuffer, _blue * SpectrumAnalyzer._amplitudeBuffer);
            _material.SetColor("_EmissionColor", _color);
        }
    }
}
