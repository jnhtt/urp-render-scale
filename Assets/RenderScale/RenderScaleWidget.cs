using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RenderScaleWidget : MonoBehaviour
{
    [SerializeField]
    private Slider renderScaleSlider;

    private UniversalRenderPipelineAsset pipelineAsset;

    private void Start()
    {
        pipelineAsset = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        if (pipelineAsset != null)
        {
            renderScaleSlider.onValueChanged.AddListener(OnValueChange);
            OnValueChange(pipelineAsset.renderScale);
        }
    }

    private void OnValueChange(float value)
    {
        if (pipelineAsset != null)
        {
            pipelineAsset.renderScale = value;
        }
    }
}
