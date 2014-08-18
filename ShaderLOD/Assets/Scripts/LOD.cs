using UnityEngine;
using System.Collections;

public class LOD : MonoBehaviour
{
		//These are the builtin LOD values for Unity shaders.
		int[] shaderLOD = new int[] { 600, 500, 400, 300, 250, 200, 150, 100 };
	
		void Start ()
		{
				StartCoroutine ("UpdateLOD");
		}
	
		void SetLOD (int LOD)
		{
				Debug.Log ("New global Maximum LOD is " + shaderLOD [LOD]);
				/*foreach (var i in renderer.sharedMaterials) {
						i.shader.maximumLOD = shaderLOD [LOD];
				}*/
				Shader.globalMaximumLOD = shaderLOD [LOD];
		}
	
		IEnumerator UpdateLOD ()
		{
				for (int i = 0; i<shaderLOD.Length; i++) {
						SetLOD (i);
						yield return new WaitForSeconds (2f);
				}
		}
	
}