using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMovement01 : MonoBehaviour
{

    // Inspector
    [SerializeField] private float m_WalkSpeed = 2.0f;
    [SerializeField] private float m_RunSpeed = 3.5f;
    [SerializeField] private float m_RotateSpeed = 8.0f;
    [SerializeField] private float m_JumpForce = 300.0f;
    [SerializeField] private float m_RunningStart = 1.0f;

    // member
    private Rigidbody m_RigidBody = null;
    private Animator m_Animator = null;
    private float m_MoveTime = 0;
    private float m_MoveSpeed = 0.0f;
    private bool m_IsGround = true;

    /*!
	 *	----------------------------------------------------------------------
	 *	@brief	生成
	*/
    private void Awake()
    {
        m_RigidBody = this.GetComponentInChildren<Rigidbody>();
        m_Animator = this.GetComponentInChildren<Animator>();
        m_MoveSpeed = m_WalkSpeed;
    }

    /*!
	 *	----------------------------------------------------------------------
	 *	@brief	初期化
	*/
    //	private void Start()
    //	{
    //	}

    /*!
	 *	----------------------------------------------------------------------
	 *	@brief	更新
	*/
    void Update()
    {
        if (null == m_RigidBody) return;
        if (null == m_Animator) return;



    }
}
