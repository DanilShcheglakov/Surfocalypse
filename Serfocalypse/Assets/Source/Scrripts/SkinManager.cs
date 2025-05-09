using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
	[SerializeField] private SOSkins _skinSettings;
	[SerializeField] private SkinnedMeshRenderer _skinnedMeshRenderer;

	private void Awake()
	{
		AplySettings();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.KeypadEnter))
		{
			AplySettings();
		}
	}


	public void AplySettings()
	{
		_skinnedMeshRenderer.material = _skinSettings.SkinMaterial;
		_skinnedMeshRenderer.sharedMesh = _skinSettings.SkinMesh;
	}
}
