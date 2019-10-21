using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraScript : MonoBehaviour {
    private Material material;
	// Use this for initialization
	void Awake () {
        material = new Material(Shader.Find("Hidden/NewImageEffectShaderTEST"));
	}
	
	// Update is called once per frame
	void OnRenderImage (RenderTexture source, RenderTexture destination) {
        Graphics.Blit(source, destination, material);
    }
}
