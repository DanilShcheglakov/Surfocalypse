using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkin", menuName = "Inventory/Skin")]
public class SOSkins : ScriptableObject
{
	[SerializeField] private Mesh _mesh;
	[SerializeField] private Material _material;

	public Material SkinMaterial => _material;
	public Mesh SkinMesh => _mesh;
}
