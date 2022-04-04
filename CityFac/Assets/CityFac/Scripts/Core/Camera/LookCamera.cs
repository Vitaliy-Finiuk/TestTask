using UnityEngine;

namespace CityFac.Scripts.Camera
{
	public class LookCamera : MonoBehaviour
	{
		[SerializeField] private float _mouseSensitivityX = 5.0f;
		[SerializeField] private float _mouseSensitivityY = 5.0f;

		private float _rotationY = 0.0f;

		private void Update()
		{
			//MouseRotation();
		}

		private void HandleMouseRotation()
		{
			float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * _mouseSensitivityX;
				_rotationY += Input.GetAxis("Mouse Y") * _mouseSensitivityY;
				_rotationY = Mathf.Clamp(_rotationY, -89.5f, 89.5f);
				transform.localEulerAngles = new Vector3(-_rotationY, rotationX, 0.0f);
		}
	}
}