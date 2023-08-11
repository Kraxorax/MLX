using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
	public class Glowable : MonoBehaviour
	{
		Renderer oneWhoRenders;

		// Use this for initialization
		void Start()
		{
			oneWhoRenders = GetComponent<Renderer>();
		}

		// Update is called once per frame
		void Update()
		{

		}

		private Color startcolor;
		void OnMouseEnter()
		{
			startcolor = oneWhoRenders.material.color;
			oneWhoRenders.material.color = Color.yellow;
		}
		void OnMouseExit()
		{
			oneWhoRenders.material.color = startcolor;
		}
	}
}